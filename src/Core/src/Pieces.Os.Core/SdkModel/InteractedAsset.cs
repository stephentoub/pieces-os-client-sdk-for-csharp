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
    /// A model that represents an asset that has been interacted with. 
    /// </summary>
    [DataContract(Name = "InteractedAsset")]
    public partial class InteractedAsset : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InteractedAsset" /> class.
        /// </summary>
        /// <param name="asset">A uuid model. 36 Characters (4 Dashes, 32 Numbers/Letters) .</param>
        /// <param name="interactions">interactions.</param>
        public InteractedAsset(Guid asset = default(Guid), InteractedAssetInteractions interactions = default(InteractedAssetInteractions))
        {
            this.Asset = asset;
            this.Interactions = interactions;
        }

        /// <summary>
        /// A uuid model. 36 Characters (4 Dashes, 32 Numbers/Letters) 
        /// </summary>
        /// <value>A uuid model. 36 Characters (4 Dashes, 32 Numbers/Letters) </value>
        /*
        <example>6a2f41a3-c54c-fce8-32d2-0324e1c32e22</example>
        */
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public Guid Asset { get; set; }

        /// <summary>
        /// Gets or Sets Interactions
        /// </summary>
        [DataMember(Name = "interactions", EmitDefaultValue = false)]
        public InteractedAssetInteractions Interactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InteractedAsset {\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
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
                            if (this.Asset != null) {
                                // Asset (Guid) pattern
                Regex regexAsset = new Regex(@"[0-9a-fA-F]{8}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{4}\-[0-9a-fA-F]{12}", RegexOptions.CultureInvariant);
                if (!regexAsset.Match(this.Asset.ToString()).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Asset, must match a pattern of " + regexAsset, new [] { "Asset" });
                }
                            }

            yield break;
        }
    }

}
