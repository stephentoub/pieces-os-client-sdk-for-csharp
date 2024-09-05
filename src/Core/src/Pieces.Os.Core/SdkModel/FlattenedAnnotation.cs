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
    /// This is the flattened Version of the annotation, IMPORTANT: when referencing these, ONLY Take the UUID, do NOT polinate(ie w/ asset/person/model) the FlattenedAnnotation as it can create an infinite loop.
    /// </summary>
    [DataContract(Name = "FlattenedAnnotation")]
    public partial class FlattenedAnnotation : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name = "mechanism", EmitDefaultValue = false)]
        public MechanismEnum? Mechanism { get; set; }

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public AnnotationTypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedAnnotation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedAnnotation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedAnnotation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="deleted">deleted.</param>
        /// <param name="mechanism">mechanism.</param>
        /// <param name="asset">asset.</param>
        /// <param name="person">person.</param>
        /// <param name="type">type (required).</param>
        /// <param name="text">This is the text of the annotation. (required).</param>
        /// <param name="model">model.</param>
        /// <param name="pseudo">pseudo.</param>
        /// <param name="favorited">favorited.</param>
        /// <param name="anchor">anchor.</param>
        /// <param name="conversation">conversation.</param>
        /// <param name="score">score.</param>
        /// <param name="messages">messages.</param>
        /// <param name="summary">summary.</param>
        public FlattenedAnnotation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), GroupedTimestamp deleted = default(GroupedTimestamp), MechanismEnum? mechanism = default(MechanismEnum?), ReferencedAsset asset = default(ReferencedAsset), ReferencedPerson person = default(ReferencedPerson), AnnotationTypeEnum type = default(AnnotationTypeEnum), string text = default(string), ReferencedModel model = default(ReferencedModel), bool pseudo = default(bool), bool favorited = default(bool), ReferencedAnchor anchor = default(ReferencedAnchor), ReferencedConversation conversation = default(ReferencedConversation), Score score = default(Score), FlattenedConversationMessages messages = default(FlattenedConversationMessages), ReferencedWorkstreamSummary summary = default(ReferencedWorkstreamSummary))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FlattenedAnnotation and cannot be null");
            }
            this.Id = id;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for FlattenedAnnotation and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for FlattenedAnnotation and cannot be null");
            }
            this.Updated = updated;
            this.Type = type;
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for FlattenedAnnotation and cannot be null");
            }
            this.Text = text;
            this.Schema = schema;
            this.Deleted = deleted;
            this.Mechanism = mechanism;
            this.Asset = asset;
            this.Person = person;
            this.Model = model;
            this.Pseudo = pseudo;
            this.Favorited = favorited;
            this.Anchor = anchor;
            this.Conversation = conversation;
            this.Score = score;
            this.Messages = messages;
            this.Summary = summary;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Updated { get; set; }

        /// <summary>
        /// Gets or Sets Deleted
        /// </summary>
        [DataMember(Name = "deleted", EmitDefaultValue = false)]
        public GroupedTimestamp Deleted { get; set; }

        /// <summary>
        /// Gets or Sets Asset
        /// </summary>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public ReferencedAsset Asset { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public ReferencedPerson Person { get; set; }

        /// <summary>
        /// This is the text of the annotation.
        /// </summary>
        /// <value>This is the text of the annotation.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", EmitDefaultValue = false)]
        public ReferencedModel Model { get; set; }

        /// <summary>
        /// Gets or Sets Pseudo
        /// </summary>
        [DataMember(Name = "pseudo", EmitDefaultValue = true)]
        public bool Pseudo { get; set; }

        /// <summary>
        /// Gets or Sets Favorited
        /// </summary>
        [DataMember(Name = "favorited", EmitDefaultValue = true)]
        public bool Favorited { get; set; }

        /// <summary>
        /// Gets or Sets Anchor
        /// </summary>
        [DataMember(Name = "anchor", EmitDefaultValue = false)]
        public ReferencedAnchor Anchor { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name = "conversation", EmitDefaultValue = false)]
        public ReferencedConversation Conversation { get; set; }

        /// <summary>
        /// Gets or Sets Score
        /// </summary>
        [DataMember(Name = "score", EmitDefaultValue = false)]
        public Score Score { get; set; }

        /// <summary>
        /// Gets or Sets Messages
        /// </summary>
        [DataMember(Name = "messages", EmitDefaultValue = false)]
        public FlattenedConversationMessages Messages { get; set; }

        /// <summary>
        /// Gets or Sets Summary
        /// </summary>
        [DataMember(Name = "summary", EmitDefaultValue = false)]
        public ReferencedWorkstreamSummary Summary { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedAnnotation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Pseudo: ").Append(Pseudo).Append("\n");
            sb.Append("  Favorited: ").Append(Favorited).Append("\n");
            sb.Append("  Anchor: ").Append(Anchor).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Score: ").Append(Score).Append("\n");
            sb.Append("  Messages: ").Append(Messages).Append("\n");
            sb.Append("  Summary: ").Append(Summary).Append("\n");
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