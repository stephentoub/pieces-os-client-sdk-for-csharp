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
    /// This is a modle that will return fro mthe search endpoint that will just contain an array of assets!
    /// </summary>
    [DataContract(Name = "SearchedAssets")]
    public partial class SearchedAssets : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedAssets" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchedAssets() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchedAssets" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        /// <param name="suggested">the number of fuzzy/suggested search results. (required).</param>
        /// <param name="exact">the number of exact results (required).</param>
        public SearchedAssets(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<SearchedAsset> iterable = default(List<SearchedAsset>), decimal suggested = default(decimal), decimal exact = default(decimal))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for SearchedAssets and cannot be null");
            }
            this.Iterable = iterable;
            this.Suggested = suggested;
            this.Exact = exact;
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
        public List<SearchedAsset> Iterable { get; set; }

        /// <summary>
        /// the number of fuzzy/suggested search results.
        /// </summary>
        /// <value>the number of fuzzy/suggested search results.</value>
        [DataMember(Name = "suggested", IsRequired = true, EmitDefaultValue = true)]
        public decimal Suggested { get; set; }

        /// <summary>
        /// the number of exact results
        /// </summary>
        /// <value>the number of exact results</value>
        [DataMember(Name = "exact", IsRequired = true, EmitDefaultValue = true)]
        public decimal Exact { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchedAssets {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
            sb.Append("  Suggested: ").Append(Suggested).Append("\n");
            sb.Append("  Exact: ").Append(Exact).Append("\n");
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