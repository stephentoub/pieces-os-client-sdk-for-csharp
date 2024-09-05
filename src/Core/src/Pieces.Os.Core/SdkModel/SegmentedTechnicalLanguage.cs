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
    /// This is the output model for &#39;/machine_learning/text/technical_language/parsers/segmentation&#39;  This will have an iterable of the segmented Technical language text/code
    /// </summary>
    [DataContract(Name = "SegmentedTechnicalLanguage")]
    public partial class SegmentedTechnicalLanguage : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentedTechnicalLanguage" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SegmentedTechnicalLanguage() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SegmentedTechnicalLanguage" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        public SegmentedTechnicalLanguage(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<SegmentedTechnicalLanguageFragment> iterable = default(List<SegmentedTechnicalLanguageFragment>))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for SegmentedTechnicalLanguage and cannot be null");
            }
            this.Iterable = iterable;
            this.Schema = schema;
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
        public List<SegmentedTechnicalLanguageFragment> Iterable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SegmentedTechnicalLanguage {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
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