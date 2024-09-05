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
    /// SeededDiscoverableRelatedTags
    /// </summary>
    [DataContract(Name = "SeededDiscoverableRelatedTags")]
    public partial class SeededDiscoverableRelatedTags : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededDiscoverableRelatedTags" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededDiscoverableRelatedTags() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededDiscoverableRelatedTags" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        /// <param name="application">This is the application id that this request is sent from. (required).</param>
        public SeededDiscoverableRelatedTags(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<SeededDiscoverableRelatedTag> iterable = default(List<SeededDiscoverableRelatedTag>), string application = default(string))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for SeededDiscoverableRelatedTags and cannot be null");
            }
            this.Iterable = iterable;
            // to ensure "application" is required (not null)
            if (application == null)
            {
                throw new ArgumentNullException("application is a required property for SeededDiscoverableRelatedTags and cannot be null");
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
        public List<SeededDiscoverableRelatedTag> Iterable { get; set; }

        /// <summary>
        /// This is the application id that this request is sent from.
        /// </summary>
        /// <value>This is the application id that this request is sent from.</value>
        [DataMember(Name = "application", IsRequired = true, EmitDefaultValue = true)]
        public string Application { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededDiscoverableRelatedTags {\n");
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