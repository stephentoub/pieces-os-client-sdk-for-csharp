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
    /// Contains info retrieved from the identity provider with which the user originally authenticates. Users may also link their profile to multiple identity providers; those identities will then also appear in this array. The contents of an individual identity provider object varies by provider, but it will typically include the following. Link: [https://auth0.com/docs/rules/user-object-in-rules]  Currently left out: - profile_data: (Object) User information associated with the connection. When profiles are linked, it is populated with the associated user info for secondary accounts.
    /// </summary>
    [DataContract(Name = "Auth0Identity")]
    public partial class Auth0Identity : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth0Identity" /> class.
        /// </summary>
        /// <param name="connection">Name of the Auth0 connection used to authenticate the user. .</param>
        /// <param name="isSocial">Indicates whether the connection is a social one. .</param>
        /// <param name="provider">mapped from user_id  -&gt; id.</param>
        /// <param name="userId">User&#39;s unique identifier for this connection/provider..</param>
        /// <param name="accessToken">accessToken.</param>
        /// <param name="expiresIn">expiresIn.</param>
        public Auth0Identity(string connection = default(string), bool isSocial = default(bool), string provider = default(string), string userId = default(string), string accessToken = default(string), int expiresIn = default(int))
        {
            this.Connection = connection;
            this.IsSocial = isSocial;
            this.Provider = provider;
            this.UserId = userId;
            this.AccessToken = accessToken;
            this.ExpiresIn = expiresIn;
        }

        /// <summary>
        /// Name of the Auth0 connection used to authenticate the user. 
        /// </summary>
        /// <value>Name of the Auth0 connection used to authenticate the user. </value>
        [DataMember(Name = "connection", EmitDefaultValue = false)]
        public string Connection { get; set; }

        /// <summary>
        /// Indicates whether the connection is a social one. 
        /// </summary>
        /// <value>Indicates whether the connection is a social one. </value>
        [DataMember(Name = "isSocial", EmitDefaultValue = true)]
        public bool IsSocial { get; set; }

        /// <summary>
        /// mapped from user_id  -&gt; id
        /// </summary>
        /// <value>mapped from user_id  -&gt; id</value>
        [DataMember(Name = "provider", EmitDefaultValue = false)]
        public string Provider { get; set; }

        /// <summary>
        /// User&#39;s unique identifier for this connection/provider.
        /// </summary>
        /// <value>User&#39;s unique identifier for this connection/provider.</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets AccessToken
        /// </summary>
        [DataMember(Name = "access_token", EmitDefaultValue = false)]
        public string AccessToken { get; set; }

        /// <summary>
        /// Gets or Sets ExpiresIn
        /// </summary>
        [DataMember(Name = "expires_in", EmitDefaultValue = false)]
        public int ExpiresIn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Auth0Identity {\n");
            sb.Append("  Connection: ").Append(Connection).Append("\n");
            sb.Append("  IsSocial: ").Append(IsSocial).Append("\n");
            sb.Append("  Provider: ").Append(Provider).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  AccessToken: ").Append(AccessToken).Append("\n");
            sb.Append("  ExpiresIn: ").Append(ExpiresIn).Append("\n");
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