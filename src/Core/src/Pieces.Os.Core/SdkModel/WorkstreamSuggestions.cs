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
    /// This is a list of the materials used in the workstream suggestions.  The feed will return a list of individual material that will be required to be fetched and re-referenced.(the materials that is.)  Considering if we want to have all the materaials just being referenced( ie ReferencedWebsite/ReferencedWorkstreamSummary/...xyz) &amp;&amp; rebuilt
    /// </summary>
    [DataContract(Name = "WorkstreamSuggestions")]
    public partial class WorkstreamSuggestions : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamSuggestions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WorkstreamSuggestions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WorkstreamSuggestions" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        /// <param name="types">This is iterable &lt;WorkstreamSuggestionType&gt;[] that gives the type of each of the items in the iterable. I.E. types[0] is the suggestion type of the item at iterable[0]..</param>
        public WorkstreamSuggestions(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<WorkstreamSuggestion> iterable = default(List<WorkstreamSuggestion>), List<WorkstreamSuggestionType> types = default(List<WorkstreamSuggestionType>))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for WorkstreamSuggestions and cannot be null");
            }
            this.Iterable = iterable;
            this.Schema = schema;
            this.Types = types;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Iterable
        /// </summary>
        [DataMember(Name = "iterable", IsRequired = true, EmitDefaultValue = true)]
        public List<WorkstreamSuggestion> Iterable { get; set; }

        /// <summary>
        /// This is iterable &lt;WorkstreamSuggestionType&gt;[] that gives the type of each of the items in the iterable. I.E. types[0] is the suggestion type of the item at iterable[0].
        /// </summary>
        /// <value>This is iterable &lt;WorkstreamSuggestionType&gt;[] that gives the type of each of the items in the iterable. I.E. types[0] is the suggestion type of the item at iterable[0].</value>
        [DataMember(Name = "types", EmitDefaultValue = false)]
        public List<WorkstreamSuggestionType> Types { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WorkstreamSuggestions {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
            sb.Append("  Types: ").Append(Types).Append("\n");
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