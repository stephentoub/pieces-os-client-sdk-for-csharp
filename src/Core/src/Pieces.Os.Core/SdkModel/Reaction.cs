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
    /// This will the the Request body of the Request Endpoint.  Reuse will not be required here because we do NOT know if the user will choose to reuse what we have suggested.  save will however be required because this will let us know if we should save the coppied asset that was first sent over or not.  seed is required, because we will want to know 100% sure what the original suggestion was made against.
    /// </summary>
    [DataContract(Name = "Reaction")]
    public partial class Reaction : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Reaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Reaction" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="save">This will just be a simple boolean here that will say if the use should save the asset or not. (required).</param>
        /// <param name="reuse">reuse.</param>
        /// <param name="seed">seed (required).</param>
        public Reaction(EmbeddedModelSchema schema = default(EmbeddedModelSchema), bool save = default(bool), ReuseReaction reuse = default(ReuseReaction), SeededConnectorCreation seed = default(SeededConnectorCreation))
        {
            this.Save = save;
            // to ensure "seed" is required (not null)
            if (seed == null)
            {
                throw new ArgumentNullException("seed is a required property for Reaction and cannot be null");
            }
            this.Seed = seed;
            this.Schema = schema;
            this.Reuse = reuse;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This will just be a simple boolean here that will say if the use should save the asset or not.
        /// </summary>
        /// <value>This will just be a simple boolean here that will say if the use should save the asset or not.</value>
        [DataMember(Name = "save", IsRequired = true, EmitDefaultValue = true)]
        public bool Save { get; set; }

        /// <summary>
        /// Gets or Sets Reuse
        /// </summary>
        [DataMember(Name = "reuse", EmitDefaultValue = false)]
        public ReuseReaction Reuse { get; set; }

        /// <summary>
        /// Gets or Sets Seed
        /// </summary>
        [DataMember(Name = "seed", IsRequired = true, EmitDefaultValue = true)]
        public SeededConnectorCreation Seed { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Reaction {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Save: ").Append(Save).Append("\n");
            sb.Append("  Reuse: ").Append(Reuse).Append("\n");
            sb.Append("  Seed: ").Append(Seed).Append("\n");
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