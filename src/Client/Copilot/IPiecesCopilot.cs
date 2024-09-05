namespace Pieces.OS.Client.Copilot;

using Pieces.Os.Core.SdkModel;

public interface IPiecesCopilot
{
    /// <summary>
    /// The AI model to use for all newly generated chats. Changing this will not affect existing chats
    /// </summary>
    Model Model { get; set; }

    /// <summary>
    /// Create a new chat with the copilot
    /// </summary>
    /// <param name="chatName">An optional name for the chat. If nothing is provided, the name will be New conversation</param>
    /// <param name="assetIds">An optional list of asset Ids to add to the chat</param>
    /// <param name="model">The LLM model to use</param>
    /// <param name="useLiveContext">Should this chat use live context or not</param>
    /// <param name="cancellationToken">A cancellation token</param>
    /// <returns>The new chat</returns>
    Task<ICopilotChat> CreateChatAsync(string chatName = "", IEnumerable<string>? assetIds = null, Model? model = default, bool useLiveContext = false, CancellationToken cancellationToken = default);

    /// <summary>
    /// Get all the chats with the current copilot
    /// </summary>
    IEnumerable<ICopilotChat> Chats { get; }
}