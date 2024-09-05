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
    /// This is used as the input in the Context ingestion endpoint for the feed.  This will take in a required seed, this will get created as an internal WorkstreamEvent until we determine internally that this event is relevant and will then attach it to a WorkstreamSummary and it will get moved over to a WorkstreamEvent.
    /// </summary>
    [DataContract(Name = "SeededWorkstreamIngestion")]
    public partial class SeededWorkstreamIngestion : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWorkstreamIngestion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededWorkstreamIngestion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededWorkstreamIngestion" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="varEvent">varEvent (required).</param>
        public SeededWorkstreamIngestion(EmbeddedModelSchema schema = default(EmbeddedModelSchema), SeededWorkstreamEvent varEvent = default(SeededWorkstreamEvent))
        {
            // to ensure "varEvent" is required (not null)
            if (varEvent == null)
            {
                throw new ArgumentNullException("varEvent is a required property for SeededWorkstreamIngestion and cannot be null");
            }
            this.VarEvent = varEvent;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets VarEvent
        /// </summary>
        [DataMember(Name = "event", IsRequired = true, EmitDefaultValue = true)]
        public SeededWorkstreamEvent VarEvent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededWorkstreamIngestion {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  VarEvent: ").Append(VarEvent).Append("\n");
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