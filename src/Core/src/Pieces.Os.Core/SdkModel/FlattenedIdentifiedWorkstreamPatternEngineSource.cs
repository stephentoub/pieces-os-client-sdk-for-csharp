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
    /// TODO
    /// </summary>
    [DataContract(Name = "FlattenedIdentifiedWorkstreamPatternEngineSource")]
    public partial class FlattenedIdentifiedWorkstreamPatternEngineSource : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedIdentifiedWorkstreamPatternEngineSource" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FlattenedIdentifiedWorkstreamPatternEngineSource() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FlattenedIdentifiedWorkstreamPatternEngineSource" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">id (required).</param>
        /// <param name="raw">raw (required).</param>
        /// <param name="created">created (required).</param>
        /// <param name="updated">updated (required).</param>
        /// <param name="filter">This will determine if we want to filter this specific source.</param>
        /// <param name="name">This is the name of the source(defualt original data) this is NOT used for matching just for readability (required).</param>
        public FlattenedIdentifiedWorkstreamPatternEngineSource(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), WorkstreamPatternEngineSource raw = default(WorkstreamPatternEngineSource), GroupedTimestamp created = default(GroupedTimestamp), GroupedTimestamp updated = default(GroupedTimestamp), bool filter = default(bool), string name = default(string))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FlattenedIdentifiedWorkstreamPatternEngineSource and cannot be null");
            }
            this.Id = id;
            // to ensure "raw" is required (not null)
            if (raw == null)
            {
                throw new ArgumentNullException("raw is a required property for FlattenedIdentifiedWorkstreamPatternEngineSource and cannot be null");
            }
            this.Raw = raw;
            // to ensure "created" is required (not null)
            if (created == null)
            {
                throw new ArgumentNullException("created is a required property for FlattenedIdentifiedWorkstreamPatternEngineSource and cannot be null");
            }
            this.Created = created;
            // to ensure "updated" is required (not null)
            if (updated == null)
            {
                throw new ArgumentNullException("updated is a required property for FlattenedIdentifiedWorkstreamPatternEngineSource and cannot be null");
            }
            this.Updated = updated;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for FlattenedIdentifiedWorkstreamPatternEngineSource and cannot be null");
            }
            this.Name = name;
            this.Schema = schema;
            this.Filter = filter;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets Raw
        /// </summary>
        [DataMember(Name = "raw", IsRequired = true, EmitDefaultValue = true)]
        public WorkstreamPatternEngineSource Raw { get; set; }

        /// <summary>
        /// Gets or Sets Created
        /// </summary>
        [DataMember(Name = "created", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Created { get; set; }

        /// <summary>
        /// Gets or Sets Updated
        /// </summary>
        [DataMember(Name = "updated", IsRequired = true, EmitDefaultValue = true)]
        public GroupedTimestamp Updated { get; set; }

        /// <summary>
        /// This will determine if we want to filter this specific source
        /// </summary>
        /// <value>This will determine if we want to filter this specific source</value>
        [DataMember(Name = "filter", EmitDefaultValue = true)]
        public bool Filter { get; set; }

        /// <summary>
        /// This is the name of the source(defualt original data) this is NOT used for matching just for readability
        /// </summary>
        /// <value>This is the name of the source(defualt original data) this is NOT used for matching just for readability</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlattenedIdentifiedWorkstreamPatternEngineSource {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Raw: ").Append(Raw).Append("\n");
            sb.Append("  Created: ").Append(Created).Append("\n");
            sb.Append("  Updated: ").Append(Updated).Append("\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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