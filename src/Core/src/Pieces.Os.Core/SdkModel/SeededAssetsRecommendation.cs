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
    /// This is the input data model for the /assets/recommend [GET] endpoint. It includes both a list of assets but also 
    /// </summary>
    [DataContract(Name = "SeededAssetsRecommendation")]
    public partial class SeededAssetsRecommendation : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededAssetsRecommendation" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededAssetsRecommendation() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededAssetsRecommendation" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="assets">assets (required).</param>
        /// <param name="interactions">interactions (required).</param>
        public SeededAssetsRecommendation(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Assets assets = default(Assets), InteractedAssets interactions = default(InteractedAssets))
        {
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for SeededAssetsRecommendation and cannot be null");
            }
            this.Assets = assets;
            // to ensure "interactions" is required (not null)
            if (interactions == null)
            {
                throw new ArgumentNullException("interactions is a required property for SeededAssetsRecommendation and cannot be null");
            }
            this.Interactions = interactions;
            this.Schema = schema;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
        public Assets Assets { get; set; }

        /// <summary>
        /// Gets or Sets Interactions
        /// </summary>
        [DataMember(Name = "interactions", IsRequired = true, EmitDefaultValue = true)]
        public InteractedAssets Interactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededAssetsRecommendation {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Interactions: ").Append(Interactions).Append("\n");
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