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
    /// A Model to describe what application a format/analytics event originated.  mechanism: This will let us know where this came from. ie.only 2 enums are used here or else throw and error. default mechanism here is MANUAL- meaning that this came from our user Connecting an application. INTERNAL - means that this came from a shareable link
    /// </summary>
    [DataContract(Name = "Application")]
    public partial class Application : IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public ApplicationNameEnum Name { get; set; }

        /// <summary>
        /// Gets or Sets Platform
        /// </summary>
        [DataMember(Name = "platform", IsRequired = true, EmitDefaultValue = true)]
        public PlatformEnum Platform { get; set; }

        /// <summary>
        /// Gets or Sets Privacy
        /// </summary>
        [DataMember(Name = "privacy", IsRequired = true, EmitDefaultValue = true)]
        public PrivacyEnum Privacy { get; set; }

        /// <summary>
        /// Gets or Sets Capabilities
        /// </summary>
        [DataMember(Name = "capabilities", EmitDefaultValue = false)]
        public CapabilitiesEnum? Capabilities { get; set; }

        /// <summary>
        /// Gets or Sets Mechanism
        /// </summary>
        [DataMember(Name = "mechanism", EmitDefaultValue = false)]
        public MechanismEnum? Mechanism { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Application() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="id">The ID of the application at the device level (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="varVersion">This is the specific version number 0.0.0 (required).</param>
        /// <param name="platform">platform (required).</param>
        /// <param name="onboarded">onboarded (required).</param>
        /// <param name="privacy">privacy (required).</param>
        /// <param name="capabilities">capabilities.</param>
        /// <param name="mechanism">mechanism.</param>
        /// <param name="automaticUnload">This is a proper that will let us know if we will proactivity unload all of your machine learning models.by default this is false..</param>
        /// <param name="enrichment">enrichment.</param>
        public Application(EmbeddedModelSchema schema = default(EmbeddedModelSchema), string id = default(string), ApplicationNameEnum name = default(ApplicationNameEnum), string varVersion = default(string), PlatformEnum platform = default(PlatformEnum), bool onboarded = default(bool), PrivacyEnum privacy = default(PrivacyEnum), CapabilitiesEnum? capabilities = default(CapabilitiesEnum?), MechanismEnum? mechanism = default(MechanismEnum?), bool automaticUnload = default(bool), SeededAssetEnrichment enrichment = default(SeededAssetEnrichment))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for Application and cannot be null");
            }
            this.Id = id;
            this.Name = name;
            // to ensure "varVersion" is required (not null)
            if (varVersion == null)
            {
                throw new ArgumentNullException("varVersion is a required property for Application and cannot be null");
            }
            this.VarVersion = varVersion;
            this.Platform = platform;
            this.Onboarded = onboarded;
            this.Privacy = privacy;
            this.Schema = schema;
            this.Capabilities = capabilities;
            this.Mechanism = mechanism;
            this.AutomaticUnload = automaticUnload;
            this.Enrichment = enrichment;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// The ID of the application at the device level
        /// </summary>
        /// <value>The ID of the application at the device level</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// This is the specific version number 0.0.0
        /// </summary>
        /// <value>This is the specific version number 0.0.0</value>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public string VarVersion { get; set; }

        /// <summary>
        /// Gets or Sets Onboarded
        /// </summary>
        [DataMember(Name = "onboarded", IsRequired = true, EmitDefaultValue = true)]
        public bool Onboarded { get; set; }

        /// <summary>
        /// This is a proper that will let us know if we will proactivity unload all of your machine learning models.by default this is false.
        /// </summary>
        /// <value>This is a proper that will let us know if we will proactivity unload all of your machine learning models.by default this is false.</value>
        [DataMember(Name = "automaticUnload", EmitDefaultValue = true)]
        public bool AutomaticUnload { get; set; }

        /// <summary>
        /// Gets or Sets Enrichment
        /// </summary>
        [DataMember(Name = "enrichment", EmitDefaultValue = false)]
        public SeededAssetEnrichment Enrichment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Application {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VarVersion: ").Append(VarVersion).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  Onboarded: ").Append(Onboarded).Append("\n");
            sb.Append("  Privacy: ").Append(Privacy).Append("\n");
            sb.Append("  Capabilities: ").Append(Capabilities).Append("\n");
            sb.Append("  Mechanism: ").Append(Mechanism).Append("\n");
            sb.Append("  AutomaticUnload: ").Append(AutomaticUnload).Append("\n");
            sb.Append("  Enrichment: ").Append(Enrichment).Append("\n");
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