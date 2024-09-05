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
    /// modeled off of (https://microsoft.github.io/language-server-protocol/specifications/lsp/3.17/specification/#codeDescription)
    /// </summary>
    [DataContract(Name = "LanguageServerProtocolCodeDescription")]
    public partial class LanguageServerProtocolCodeDescription : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageServerProtocolCodeDescription" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LanguageServerProtocolCodeDescription() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageServerProtocolCodeDescription" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="href">href (required).</param>
        public LanguageServerProtocolCodeDescription(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string href = default(string))
        {
            // to ensure "href" is required (not null)
            if (href == null)
            {
                throw new ArgumentNullException("href is a required property for LanguageServerProtocolCodeDescription and cannot be null");
            }
            this.Href = href;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Href
        /// </summary>
        [DataMember(Name = "href", IsRequired = true, EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LanguageServerProtocolCodeDescription {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
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