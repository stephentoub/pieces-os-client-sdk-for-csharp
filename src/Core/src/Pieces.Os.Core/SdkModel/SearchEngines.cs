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
    /// This is a model for plural Engine. This means that you can run multiple searches, this follow similar behavior to the Asset Filtering.where you can create you own complex operations: IE search a query in FTS, and filter all that have the create from here to here.  note: each Engine will only represent 1 search operation, however you many pass in operations to create further nesting. IE  Engine: [FTS + w/ operations: [created filter, updated filer, ncs Search] w/ a type of OR:::: This can be as nested as you want however will just increase the time till it returns results.]  note: type: default behavior for the type is an AND operation.
    /// </summary>
    [DataContract(Name = "SearchEngines")]
    public partial class SearchEngines : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public FilterOperationTypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEngines" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SearchEngines() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEngines" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="iterable">iterable (required).</param>
        /// <param name="type">type.</param>
        public SearchEngines(EmbeddedModelSchema schema = default(EmbeddedModelSchema), List<SearchEngine> iterable = default(List<SearchEngine>), FilterOperationTypeEnum? type = default(FilterOperationTypeEnum?))
        {
            // to ensure "iterable" is required (not null)
            if (iterable == null)
            {
                throw new ArgumentNullException("iterable is a required property for SearchEngines and cannot be null");
            }
            this.Iterable = iterable;
            this.Schema = schema;
            this.Type = type;
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
        public List<SearchEngine> Iterable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchEngines {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Iterable: ").Append(Iterable).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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