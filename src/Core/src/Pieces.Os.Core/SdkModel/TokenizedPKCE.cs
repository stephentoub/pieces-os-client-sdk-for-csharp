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
    /// This is the flow that mobile apps use to access an API. Use this endpoint to exchange an Authorization Code for a Token.
    /// </summary>
    [DataContract(Name = "TokenizedPKCE")]
    public partial class TokenizedPKCE : IValidatableObject
    {
        /// <summary>
        /// Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token.
        /// </summary>
        /// <value>Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GrantTypeEnum
        {
            /// <summary>
            /// Enum RefreshToken for value: refresh_token
            /// </summary>
            [EnumMember(Value = "refresh_token")]
            RefreshToken = 1,

            /// <summary>
            /// Enum AuthorizationCode for value: authorization_code
            /// </summary>
            [EnumMember(Value = "authorization_code")]
            AuthorizationCode = 2
        }


        /// <summary>
        /// Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token.
        /// </summary>
        /// <value>Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token.</value>
        [DataMember(Name = "grant_type", IsRequired = true, EmitDefaultValue = true)]
        public GrantTypeEnum GrantType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizedPKCE" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TokenizedPKCE() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenizedPKCE" /> class.
        /// </summary>
        /// <param name="schema">schema.</param>
        /// <param name="grantType">Denotes the flow you are using. For Authorization Code, use authorization_code or refresh_token. (required).</param>
        /// <param name="clientId">Your application&#39;s Client ID. (required).</param>
        /// <param name="code">The Authorization Code received from the initial /authorize call. (required).</param>
        /// <param name="redirectUri">This is required only if it was set at the GET /authorize endpoint. The values must match. (required).</param>
        /// <param name="codeVerifier">Cryptographically random key that was used to generate the code_challenge passed to /authorize. (required).</param>
        /// <param name="audience">The audience domain: i.e. https://pieces.us.auth0.com.</param>
        public TokenizedPKCE(EmbeddedModelSchema schema = default(EmbeddedModelSchema), GrantTypeEnum grantType = default(GrantTypeEnum), string clientId = default(string), string code = default(string), string redirectUri = default(string), string codeVerifier = default(string), string audience = default(string))
        {
            this.GrantType = grantType;
            // to ensure "clientId" is required (not null)
            if (clientId == null)
            {
                throw new ArgumentNullException("clientId is a required property for TokenizedPKCE and cannot be null");
            }
            this.ClientId = clientId;
            // to ensure "code" is required (not null)
            if (code == null)
            {
                throw new ArgumentNullException("code is a required property for TokenizedPKCE and cannot be null");
            }
            this.Code = code;
            // to ensure "redirectUri" is required (not null)
            if (redirectUri == null)
            {
                throw new ArgumentNullException("redirectUri is a required property for TokenizedPKCE and cannot be null");
            }
            this.RedirectUri = redirectUri;
            // to ensure "codeVerifier" is required (not null)
            if (codeVerifier == null)
            {
                throw new ArgumentNullException("codeVerifier is a required property for TokenizedPKCE and cannot be null");
            }
            this.CodeVerifier = codeVerifier;
            this.Schema = schema;
            this.Audience = audience;
        }

        /// <summary>
        /// Gets or Sets Schema
        /// </summary>
        [DataMember(Name = "schema", EmitDefaultValue = false)]
        public EmbeddedModelSchema Schema { get; set; }

        /// <summary>
        /// Your application&#39;s Client ID.
        /// </summary>
        /// <value>Your application&#39;s Client ID.</value>
        [DataMember(Name = "client_id", IsRequired = true, EmitDefaultValue = true)]
        public string ClientId { get; set; }

        /// <summary>
        /// The Authorization Code received from the initial /authorize call.
        /// </summary>
        /// <value>The Authorization Code received from the initial /authorize call.</value>
        [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// This is required only if it was set at the GET /authorize endpoint. The values must match.
        /// </summary>
        /// <value>This is required only if it was set at the GET /authorize endpoint. The values must match.</value>
        [DataMember(Name = "redirect_uri", IsRequired = true, EmitDefaultValue = true)]
        public string RedirectUri { get; set; }

        /// <summary>
        /// Cryptographically random key that was used to generate the code_challenge passed to /authorize.
        /// </summary>
        /// <value>Cryptographically random key that was used to generate the code_challenge passed to /authorize.</value>
        [DataMember(Name = "code_verifier", IsRequired = true, EmitDefaultValue = true)]
        public string CodeVerifier { get; set; }

        /// <summary>
        /// The audience domain: i.e. https://pieces.us.auth0.com
        /// </summary>
        /// <value>The audience domain: i.e. https://pieces.us.auth0.com</value>
        /*
        <example>https://pieces.us.auth0.com</example>
        */
        [DataMember(Name = "audience", EmitDefaultValue = false)]
        public string Audience { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TokenizedPKCE {\n");
            sb.Append("  Schema: ").Append(Schema).Append("\n");
            sb.Append("  GrantType: ").Append(GrantType).Append("\n");
            sb.Append("  ClientId: ").Append(ClientId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  RedirectUri: ").Append(RedirectUri).Append("\n");
            sb.Append("  CodeVerifier: ").Append(CodeVerifier).Append("\n");
            sb.Append("  Audience: ").Append(Audience).Append("\n");
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
