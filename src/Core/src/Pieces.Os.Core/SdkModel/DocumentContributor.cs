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
    /// A DocumentContributor is a preseeded representation of a Person  This can be used in the case of the browser, or in the IDE  If they are apart of an IDE, we can in the future provide git information (IE add a Git object for their commits)  person: this is most important part which is the email/name xyz
    /// </summary>
    [DataContract(Name = "DocumentContributor")]
    public partial class DocumentContributor : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentContributor" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DocumentContributor() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DocumentContributor" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="classification">classification.</param>
        /// <param name="value">value.</param>
        /// <param name="person">person (required).</param>
        /// <param name="updated">updated.</param>
        public DocumentContributor(EmbeddedModelSchema schema = default(EmbeddedModelSchema), Classification classification = default(Classification), TransferableString value = default(TransferableString), PersonBasicType person = default(PersonBasicType), GroupedTimestamp updated = default(GroupedTimestamp))
        {
            // to ensure "person" is required (not null)
            if (person == null)
            {
                throw new ArgumentNullException("person is a required property for DocumentContributor and cannot be null");
            }
            this.Person = person;
            this.Schema = schema;
            this.Classification = classification;
            this.Value = value;
            this.Updated = updated;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Classification
        /// </summary>
        [DataMember(Name = "classification", EmitDefaultValue = false)]
        public Classification Classification { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public TransferableString Value { get; set; }

        /// <summary>
        /// Gets or Sets Person
        /// </summary>
        [DataMember(Name = "person", IsRequired = true, EmitDefaultValue = true)]
        public PersonBasicType Person { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", EmitDefaultValue = false)]
        public GroupedTimestamp Updated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocumentContributor {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Classification: ").Append(Classification).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Person: ").Append(Person).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
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