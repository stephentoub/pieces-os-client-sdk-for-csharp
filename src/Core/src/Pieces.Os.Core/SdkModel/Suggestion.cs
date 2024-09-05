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
    /// This is the model return by the connector&#39;s suggest endpoint.  Note: assets are the assets that this target was ran against.  distribution is the distribution that we generated from comparing the target to the asset&#39;s vectors.(currently uuid(assetid) : value that is the difference between the asset and the target) **could potentially make an additional model here that is an array from most to least relevent.  *** distribution is required but we are currently unable to reflect that with our current dart generation.
    /// </summary>
    [DataContract(Name = "Suggestion")]
    public partial class Suggestion : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Suggestion() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Suggestion" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="reuse">reuse (required).</param>
        /// <param name="save">save (required).</param>
        /// <param name="target">target (required).</param>
        /// <param name="assets">assets (required).</param>
        /// <param name="distribution">distribution.</param>
        public Suggestion(EmbeddedModelSchema schema = default(EmbeddedModelSchema), ReuseSuggestion reuse = default(ReuseSuggestion), SaveSuggestion save = default(SaveSuggestion), SuggestionTarget target = default(SuggestionTarget), Assets assets = default(Assets), Dictionary<string, decimal> distribution = default(Dictionary<string, decimal>))
        {
            // to ensure "reuse" is required (not null)
            if (reuse == null)
            {
                throw new ArgumentNullException("reuse is a required property for Suggestion and cannot be null");
            }
            this.Reuse = reuse;
            // to ensure "save" is required (not null)
            if (save == null)
            {
                throw new ArgumentNullException("save is a required property for Suggestion and cannot be null");
            }
            this.Save = save;
            // to ensure "target" is required (not null)
            if (target == null)
            {
                throw new ArgumentNullException("target is a required property for Suggestion and cannot be null");
            }
            this.Target = target;
            // to ensure "assets" is required (not null)
            if (assets == null)
            {
                throw new ArgumentNullException("assets is a required property for Suggestion and cannot be null");
            }
            this.Assets = assets;
            this.Schema = schema;
            this.Distribution = distribution;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Reuse
        /// </summary>
        [DataMember(Name = "reuse", IsRequired = true, EmitDefaultValue = true)]
        public ReuseSuggestion Reuse { get; set; }

        /// <summary>
        /// Gets or Sets Save
        /// </summary>
        [DataMember(Name = "save", IsRequired = true, EmitDefaultValue = true)]
        public SaveSuggestion Save { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", IsRequired = true, EmitDefaultValue = true)]
        public SuggestionTarget Target { get; set; }

        /// <summary>
        /// Gets or Sets Assets
        /// </summary>
        [DataMember(Name = "assets", IsRequired = true, EmitDefaultValue = true)]
        public Assets Assets { get; set; }

        /// <summary>
        /// Gets or Sets Distribution
        /// </summary>
        [DataMember(Name = "distribution", EmitDefaultValue = false)]
        public Dictionary<string, decimal> Distribution { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Suggestion {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Reuse: ").Append(Reuse).Append("\n");
            sb.Append("  Save: ").Append(Save).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
            sb.Append("  Assets: ").Append(Assets).Append("\n");
            sb.Append("  Distribution: ").Append(Distribution).Append("\n");
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