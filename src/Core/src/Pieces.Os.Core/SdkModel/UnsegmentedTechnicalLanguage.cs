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
    /// This is the input model for &#39;/machine_learning/text/technical_language/parsers/segmentation&#39;  This will take the unsegmentedText here!
    /// </summary>
    [DataContract(Name = "UnsegmentedTechnicalLanguage")]
    public partial class UnsegmentedTechnicalLanguage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsegmentedTechnicalLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UnsegmentedTechnicalLanguage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UnsegmentedTechnicalLanguage" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="value">value (required).</param>
        public UnsegmentedTechnicalLanguage(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string value = default(string))
        {
            // to ensure "value" is required (not null)
            if (value == null)
            {
                throw new ArgumentNullException("value is a required property for UnsegmentedTechnicalLanguage and cannot be null");
            }
            this.Value = value;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnsegmentedTechnicalLanguage {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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