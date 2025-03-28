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
    /// These are the references of the formats **Only UUIDS**
    /// </summary>
    [DataContract(Name = "FlattenedPreview")]
    public partial class FlattenedPreview : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedPreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedPreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedPreview" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="varBase">this is a reference(uuid) to the base format (required).</param>
        /// <param name="overlay">this is a reference(uuid) to the overlay format.</param>
        public FlattenedPreview(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string varBase = default(string), string overlay = default(string))
        {
            // to ensure "varBase" is required (not null)
            if (varBase == null)
            {
                throw new ArgumentNullException("varBase is a required property for FlattenedPreview and cannot be null");
            }
            this.Base = varBase;
            this.Schema = schema;
            this.Overlay = overlay;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// this is a reference(uuid) to the base format
        /// </summary>
        /// <value>this is a reference(uuid) to the base format</value>
        [DataMember(Name = "base", IsRequired = true, EmitDefaultValue = true)]
        public string Base { get; set; }

        /// <summary>
        /// this is a reference(uuid) to the overlay format
        /// </summary>
        /// <value>this is a reference(uuid) to the overlay format</value>
        [DataMember(Name = "overlay", EmitDefaultValue = false)]
        public string Overlay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedPreview {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Base: ").Append(Base).Append("\n");
            sb.Append("  Overlay: ").Append(Overlay).Append("\n");
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
