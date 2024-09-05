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
    /// This is the output model for \&quot;/conversation/{conversation}/summarize
    /// </summary>
    [DataContract(Name = "ConversationSummarizeOutput")]
    public partial class ConversationSummarizeOutput : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummarizeOutput" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConversationSummarizeOutput() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationSummarizeOutput" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="conversation">conversation (required).</param>
        /// <param name="annotation">annotation (required).</param>
        public ConversationSummarizeOutput(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ReferencedConversation conversation = default(ReferencedConversation), ReferencedAnnotation annotation = default(ReferencedAnnotation))
        {
            // to ensure "conversation" is required (not null)
            if (conversation == null)
            {
                throw new ArgumentNullException("conversation is a required property for ConversationSummarizeOutput and cannot be null");
            }
            this.Conversation = conversation;
            // to ensure "annotation" is required (not null)
            if (annotation == null)
            {
                throw new ArgumentNullException("annotation is a required property for ConversationSummarizeOutput and cannot be null");
            }
            this.Annotation = annotation;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Conversation
        /// </summary>
        [DataMember(Name = "conversation", IsRequired = true, EmitDefaultValue = true)]
        public ReferencedConversation Conversation { get; set; }

        /// <summary>
        /// Gets or Sets Annotation
        /// </summary>
        [DataMember(Name = "annotation", IsRequired = true, EmitDefaultValue = true)]
        public ReferencedAnnotation Annotation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConversationSummarizeOutput {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Conversation: ").Append(Conversation).Append("\n");
            sb.Append("  Annotation: ").Append(Annotation).Append("\n");
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