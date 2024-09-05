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
    /// DiscoveredSensitives
    /// </summary>
    [DataContract(Name = "DiscoveredSensitives")]
    public partial class DiscoveredSensitives : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredSensitives" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DiscoveredSensitives() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscoveredSensitives" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        /// <param name="application">application (required).</param>
        public DiscoveredSensitives(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<DiscoveredSensitive> iterable = default(List<DiscoveredSensitive>), string application = default(string))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for DiscoveredSensitives and cannot be null");
            }
            this.Iterable = iterable;
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for DiscoveredSensitives and cannot be null");
            }
            this.Application = application;
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
        public List<DiscoveredSensitive> Iterable { get; set; }

        /// <summary>
        /// Gets or Sets Application
        /// </summary>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscoveredSensitives {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
            sb.Append("  Application: ").Append(Application).Append("\n");
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