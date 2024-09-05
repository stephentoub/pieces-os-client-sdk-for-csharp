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
    /// This is a model that will hold relavent information in relation to an interaction(ONLY CLICK/TAP) analytics event(usage). If you want to register an event that relates to an interaction with the key then register a Keyboard Event. 
    /// </summary>
    [DataContract(Name = "TrackedInteractionEvent")]
    public partial class TrackedInteractionEvent : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedInteractionEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TrackedInteractionEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TrackedInteractionEvent" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="description">(optional) a description of this button that was clicked. or maybe what it did. (required).</param>
        /// <param name="element">This is an identifer that will allow the developer to know what unique button/field was interacted with..</param>
        public TrackedInteractionEvent(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string description = default(string), string element = default(string))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for TrackedInteractionEvent and cannot be null");
            }
            this.Description = description;
            this.Schema = schema;
            this.Element = element;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// (optional) a description of this button that was clicked. or maybe what it did.
        /// </summary>
        /// <value>(optional) a description of this button that was clicked. or maybe what it did.</value>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// This is an identifer that will allow the developer to know what unique button/field was interacted with.
        /// </summary>
        /// <value>This is an identifer that will allow the developer to know what unique button/field was interacted with.</value>
        [DataMember(Name = "element", EmitDefaultValue = false)]
        public string Element { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TrackedInteractionEvent {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Element: ").Append(Element).Append("\n");
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