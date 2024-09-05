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
    /// This is the minimum information needed when creating a Tag.  Default we will attach manual to a tag unless otherwise specified for mechanism.  you can optionally add an asset, format, or person uuid to attach this tag directly to it  TODO consider updating these asset,format to referenced Models
    /// </summary>
    [DataContract(Name = "SeededTag")]
    public partial class SeededTag : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name = "mechanism", EmitDefaultValue = false)]
        public MechanismEnum? Mechanism { get; set; }

        /// <summary>
        /// Gets or Sets Category
        /// </summary>
        [DataMember(Name = "category", EmitDefaultValue = false)]
        public TagCategoryEnum? Category { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededTag" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SeededTag() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SeededTag" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="text">This is the description of the tag. (required).</param>
        /// <param name="asset">this is a uuid that references an asset..</param>
        /// <param name="mechanism">mechanism.</param>
        /// <param name="category">category.</param>
        /// <param name="person">uuid of the person, you want to add this tag too.</param>
        public SeededTag(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string text = default(string), string asset = default(string), MechanismEnum? mechanism = default(MechanismEnum?), TagCategoryEnum? category = default(TagCategoryEnum?), string person = default(string))
        {
            // to ensure "text" is required (not null)
            if (text == null)
            {
                throw new ArgumentNullException("text is a required property for SeededTag and cannot be null");
            }
            this.Text = text;
            this.Schema = schema;
            this.Asset = asset;
            this.Mechanism = mechanism;
            this.Category = category;
            this.Person = person;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// This is the description of the tag.
        /// </summary>
        /// <value>This is the description of the tag.</value>
        [DataMember(Name = "text", IsRequired = true, EmitDefaultValue = true)]
        public string Text { get; set; }

        /// <summary>
        /// this is a uuid that references an asset.
        /// </summary>
        /// <value>this is a uuid that references an asset.</value>
        [DataMember(Name = "asset", EmitDefaultValue = false)]
        public string Asset { get; set; }

        /// <summary>
        /// uuid of the person, you want to add this tag too
        /// </summary>
        /// <value>uuid of the person, you want to add this tag too</value>
        [DataMember(Name = "person", EmitDefaultValue = false)]
        public string Person { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SeededTag {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Asset: ").Append(Asset).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  Category: ").Append(Category).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
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