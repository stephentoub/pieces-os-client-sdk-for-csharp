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
    /// This will determine the type of search that will run  These are all different searching methods all of which are exclusive. Meaning that you cannot mix &amp; match types.  operations: is here if you want to build complex searching behavior. (A || B) &amp;&amp; (B || C) , note this can get very complex but can be as flexible as you need.
    /// </summary>
    [DataContract(Name = "SearchEngine")]
    public partial class SearchEngine : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchEngine" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="query">query.</param>
        /// <param name="embeddings">embeddings.</param>
        /// <param name="fullText">fullText.</param>
        /// <param name="temporal">temporal.</param>
        /// <param name="workstream">workstream.</param>
        /// <param name="operations">operations.</param>
        public SearchEngine(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string query = default(string), EmbeddingsSearchOptions embeddings = default(EmbeddingsSearchOptions), FullTextSearchOptions fullText = default(FullTextSearchOptions), TemporalSearchOptions temporal = default(TemporalSearchOptions), WorkstreamSearchOptions workstream = default(WorkstreamSearchOptions), SearchEngines operations = default(SearchEngines))
        {
            this.Schema = schema;
            this.Query = query;
            this.Embeddings = embeddings;
            this.FullText = fullText;
            this.Temporal = temporal;
            this.Workstream = workstream;
            this.Operations = operations;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", EmitDefaultValue = false)]
        public string Query { get; set; }

        /// <summary>
        /// Gets or Sets Embeddings
        /// </summary>
        [DataMember(Name = "embeddings", EmitDefaultValue = false)]
        public EmbeddingsSearchOptions Embeddings { get; set; }

        /// <summary>
        /// Gets or Sets FullText
        /// </summary>
        [DataMember(Name = "full_text", EmitDefaultValue = false)]
        public FullTextSearchOptions FullText { get; set; }

        /// <summary>
        /// Gets or Sets Temporal
        /// </summary>
        [DataMember(Name = "temporal", EmitDefaultValue = false)]
        public TemporalSearchOptions Temporal { get; set; }

        /// <summary>
        /// Gets or Sets Workstream
        /// </summary>
        [DataMember(Name = "workstream", EmitDefaultValue = false)]
        public WorkstreamSearchOptions Workstream { get; set; }

        /// <summary>
        /// Gets or Sets Operations
        /// </summary>
        [DataMember(Name = "operations", EmitDefaultValue = false)]
        public SearchEngines Operations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SearchEngine {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Embeddings: ").Append(Embeddings).Append("\n");
            sb.Append("  FullText: ").Append(FullText).Append("\n");
            sb.Append("  Temporal: ").Append(Temporal).Append("\n");
            sb.Append("  Workstream: ").Append(Workstream).Append("\n");
            sb.Append("  Operations: ").Append(Operations).Append("\n");
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