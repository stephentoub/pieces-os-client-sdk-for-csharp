namespace Pieces.OS.Client.Copilot;

using Pieces.Os.Core.SdkModel;
using Pieces.OS.Client.WebSocket;
using Microsoft.Extensions.Logging;

public class PiecesCopilot : IPiecesCopilot
{
    private readonly WebSocketBackgroundClient<QGPTStreamOutput> client;
    private readonly List<ICopilotChat> copilotChats = [];
    private readonly ILogger? logger;
    private readonly Application application;
    private readonly PiecesApis piecesApis;

    internal PiecesCopilot(ILogger? logger,
                           Model model,
                           Application application,
                           WebSocketBackgroundClient<QGPTStreamOutput> client,
                           PiecesApis piecesApis)
    {
        this.logger = logger;
        Model = model;
        this.application = application;
        this.client = client;
        this.piecesApis = piecesApis;
    }

    /// <summary>
    /// Get all the chats with the current copilot
    /// </summary>
    public IEnumerable<ICopilotChat> Chats
    {
        get { return copilotChats; }
    }

    /// <summary>
    /// The AI model to use for all newly generated chats. Changing this will not affect existing chats
    /// </summary>
    public Model Model { get; set; }

    /// <summary>
    /// Create a new chat with the copilot
    /// </summary>
    /// <param name="chatName">An optional name for the chat. If nothing is provided, the name will be New conversation</param>
    /// <param name="chatContext">An optional list of asset Ids to add to the chat</param>
    /// <param name="model">The LLM model to use</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The new chat</returns>
    public Task<ICopilotChat> CreateChatAsync(string chatName = "",
                                              ChatContext? chatContext = null,
                                              Model? model = default,
                                              CancellationToken cancellationToken = default)
    {
        return CreateSeededChatAsync(chatName: chatName,
                                     seeds: null,
                                     chatContext: chatContext,
                                     model: model,
                                     cancellationToken: cancellationToken);
    }

    /// <summary>
    /// Create a new chat with the copilot seeded with messages
    /// </summary>
    /// <param name="chatName">An optional name for the chat. If nothing is provided, the name will be New conversation</param>
    /// <param name="seeds">A set of seeded messages for the conversation</param>
    /// <param name="chatContext">An optional list of asset Ids to add to the chat</param>
    /// <param name="model">The LLM model to use</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The new chat</returns>
    public async Task<ICopilotChat> CreateSeededChatAsync(string chatName = "",
                                             IEnumerable<SeedMessage>? seeds = null,
                                             ChatContext? chatContext = null,
                                             Model? model = default,
                                             CancellationToken cancellationToken = default)
    {
        chatName = string.IsNullOrWhiteSpace(chatName) ? "New Conversation" : chatName;

        QGPTPromptPipeline? pipeline;

        if (chatContext?.LongTermMemory == true)
        {
            logger?.LogDebug("Creating copilot chat with Pieces Long-Term Memory");
            var dialog = new QGPTConversationPipelineForContextualizedCodeWorkstreamDialog();
            var conversationPipeline = new QGPTConversationPipeline(contextualizedCodeWorkstreamDialog: dialog);
            pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
        }
        else
        {
            logger?.LogDebug("Creating copilot chat without Pieces Long-Term Memory");
            var dialog = new QGPTConversationPipelineForGeneralizedCodeDialog();
            var conversationPipeline = new QGPTConversationPipeline(generalizedCodeDialog: dialog);
            pipeline = new QGPTPromptPipeline(conversation: conversationPipeline);
        }

        logger?.LogInformation("Creating conversation {name}...", chatName);

        // If we have any seeds, use them
        List<SeededConversationMessage>? conversationMessages = null;
        if (seeds is not null && seeds.Any())
        {
            conversationMessages = seeds.Select(s =>
            {
                var fragment = new FragmentFormat(varString: new TransferableString(raw: s.Message));
                return new SeededConversationMessage(model: model,
                                                     role: s.Role.ToQGPTRole(),
                                                     fragment: fragment);
            }).ToList();
        }

        var seededConversation = new SeededConversation(type: ConversationTypeEnum.COPILOT,
                                                        name: chatName,
                                                        messages: conversationMessages,
                                                        pipeline: pipeline
                                                        );
        var conversation = await piecesApis.ConversationsApi.ConversationsCreateSpecificConversationAsync(
            seededConversation: seededConversation,
            cancellationToken: cancellationToken).ConfigureAwait(false);

        logger?.LogInformation("Conversation {name} created", chatName);

        var chat = new CopilotChat(logger, model ?? Model, application, client, conversation, piecesApis, chatContext, seeds);
        copilotChats.Add(chat);

        logger?.LogInformation("Copilot chat {name} created", chatName);

        return chat;
    }

    /// <summary>
    /// Deletes a copilot chat
    /// </summary>
    /// <param name="chat">The chat to delete</param>
    /// <returns></returns>
    public async Task DeleteChatAsync(ICopilotChat chat, CancellationToken cancellationToken = default)
    {
        await piecesApis.ConversationsApi.ConversationsDeleteSpecificConversationAsync(conversation: chat.Id, cancellationToken: cancellationToken).ConfigureAwait(false);
        ((CopilotChat)chat).Deleted = true;
    }
}
