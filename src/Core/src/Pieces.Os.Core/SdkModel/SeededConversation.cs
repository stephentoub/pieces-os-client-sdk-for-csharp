/*
 * Pieces Isomorphic OpenAPI
 *
 * Endpoints for Assets, Formats, Users, Asset, Format, User.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: tsavo@pieces.app
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Pieces.Os.Core.Client.OpenAPIDateConverter;

namespace Pieces.Os.Core.SdkModel
{
    /// <summary>
    /// This is a pre-Conversation object.  This will hold together a conversation. Ie allthe message within a conversation.  All the additional properties on here used on here like(anchors/assets) are used for context that will seed the conversation.  model is a calculated property, and will be the model of the last message sent if applicable.
    /// </summary>
    [DataContract(Name = "SeededConversation")]
    public partial class SeededConversation : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public ConversationTypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededConversation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededConversation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededConversation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="name">This is a name that is customized..</param>
        /// <param name="favorited">favorited.</param>
        /// <param name="application">application.</param>
        /// <param name="annotations">annotations.</param>
        /// <param name="messages">messages.</param>
        /// <param name="model">model.</param>
        /// <param name="assets">assets.</param>
        /// <param name="websites">websites.</param>
        /// <param name="anchors">anchors.</param>
        /// <param name="type">type (required).</param>
        /// <param name="pipeline">pipeline.</param>
        /// <param name="demo">This will let us know if this conversation was generated as a &#39;demo&#39; conversation.</param>
        public SeededConversation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string name = default(string), bool favorited = default(bool), Application application = default(Application), List<SeededAnnotation> annotations = default(List<SeededAnnotation>), List<SeededConversationMessage> messages = default(List<SeededConversationMessage>), ReferencedModel model = default(ReferencedModel), FlattenedAssets assets = default(FlattenedAssets), FlattenedWebsites websites = default(FlattenedWebsites), List<SeededAnchor> anchors = default(List<SeededAnchor>), ConversationTypeEnum type = default(ConversationTypeEnum), QGPTPromptPipeline pipeline = default(QGPTPromptPipeline), bool demo = default(bool))
        {
            this.Type = type;
            this.Schema = schema;
            this.Name = name;
            this.Favorited = favorited;
            this.Application = application;
            this.Annotations = annotations;
            this.Messages = messages;
            this.Model = model;
            this.Assets = assets;
            this.Websites = websites;
            this.Anchors = anchors;
            this.Pipeline = pipeline;
            this.Demo = demo;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is a name that is customized.
        /// </summary>
        /// <value>This is a name that is customized.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Favorited
        /// </summary>
        [DataMember(Name = "favorited", EmitDefaultValue = true)]
        public bool Favorited { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", EmitDefaultValue = false)]
        public Application Application { get; set; }

        /// <summary>
        /// Gets or Sets Annotations
        /// </summary>
        [DataMember(Name = "annotations", EmitDefaultValue = false)]
        public List<SeededAnnotation> Annotations { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public List<SeededConversationMessage> Messages { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public ReferencedModel Model { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", EmitDefaultValue = false)]
        public FlattenedAssets Assets { get; set; }

        /// <summary>
        /// Gets or Sets Websites
        /// </summary>
        [DataMember(Name = "websites", EmitDefaultValue = false)]
        public FlattenedWebsites Websites { get; set; }

        /// <summary>
        /// Gets or Sets Anchors
        /// </summary>
        [DataMember(Name = "anchors", EmitDefaultValue = false)]
        public List<SeededAnchor> Anchors { get; set; }

        /// <summary>
        /// Gets or Sets Pipeline
        /// </summary>
        [DataMember(Name = "pipeline", EmitDefaultValue = false)]
        public QGPTPromptPipeline Pipeline { get; set; }

        /// <summary>
        /// This will let us know if this conversation was generated as a &#39;demo&#39; conversation
        /// </summary>
        /// <value>This will let us know if this conversation was generated as a &#39;demo&#39; conversation</value>
        [DataMember(Name = "demo", EmitDefaultValue = true)]
        public bool Demo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededConversation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Favorited: ").Append(Favorited).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
            sb.Append("  Annotations: ").Append(Annotations).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Websites: ").Append(Websites).Append("\n");
            sb.Append("  Anchors: ").Append(Anchors).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  Demo: ").Append(Demo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

            /// <summary>
            /// To validate all properties of the instance
            /// </summary>
            /// <param name="validationContext">Validation context</param>
            /// <returns>Validation Result</returns>
            IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
            {
            yield break;
        }
    }

}