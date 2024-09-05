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
    /// A helper classs to wrap Date-Time Values with Useful Helper Properties
    /// </summary>
    [DataContract(Name = "GroupedTimestamp")]
    public partial class GroupedTimestamp : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedTimestamp" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupedTimestamp() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupedTimestamp" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="value">value (required).</param>
        /// <param name="readable">readable.</param>
        public GroupedTimestamp(EmbeddedModelSchema schema = default(EmbeddedModelSchema), DateTime value = default(DateTime), string readable = default(string))
        {
            this.Value = value;
            this.Schema = schema;
            this.Readable = readable;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Value
        /// </summary>
        [DataMember(Name = "value", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Value { get; set; }

        /// <summary>
        /// Gets or Sets Readable
        /// </summary>
        /// <example>Last week - June 3rd, 3:33 a.m.</example>
        [DataMember(Name = "readable", EmitDefaultValue = false)]
        public string Readable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupedTimestamp {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Readable: ").Append(Readable).Append("\n");
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