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
    /// Auth0User
    /// </summary>
    [DataContract(Name = "Auth0User")]
    public partial class Auth0User : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Auth0User" /> class.
        /// </summary>
        /// <param name="name"> User&#39;s full name..</param>
        /// <param name="picture">mapped from picture.URL pointing to the user&#39;s profile picture. .</param>
        /// <param name="email">email.</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="emailVerified">Indicates whether the user has verified their email address. Mapped from email_verified -&gt; emailVerified..</param>
        /// <param name="familyName">User&#39;s family name..</param>
        /// <param name="givenName">User&#39;s given name. .</param>
        /// <param name="identities">Contains info retrieved from the identity provider with which the user originally authenticates..</param>
        /// <param name="nickname">User&#39;s nickname. .</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="username"> (unique) User&#39;s username.  .</param>
        /// <param name="userMetadata">userMetadata.</param>
        /// <param name="locale">locale.</param>
        /// <param name="userId">userId.</param>
        /// <param name="lastIp">lastIp.</param>
        /// <param name="lastLogin">lastLogin.</param>
        /// <param name="loginsCount">loginsCount.</param>
        /// <param name="blockedFor">blockedFor.</param>
        /// <param name="guardianAuthenticators">guardianAuthenticators.</param>
        public Auth0User(string name = default(string), string picture = default(string), string email = default(string), DateTime createdAt = default(DateTime), bool emailVerified = default(bool), string familyName = default(string), string givenName = default(string), List<Auth0Identity> identities = default(List<Auth0Identity>), string nickname = default(string), DateTime updatedAt = default(DateTime), string username = default(string), Auth0UserMetadata userMetadata = default(Auth0UserMetadata), string locale = default(string), string userId = default(string), string lastIp = default(string), DateTime lastLogin = default(DateTime), int loginsCount = default(int), List<string> blockedFor = default(List<string>), List<string> guardianAuthenticators = default(List<string>))
        {
            this.Name = name;
            this.Picture = picture;
            this.Email = email;
            this.CreatedAt = createdAt;
            this.EmailVerified = emailVerified;
            this.FamilyName = familyName;
            this.GivenName = givenName;
            this.Identities = identities;
            this.Nickname = nickname;
            this.UpdatedAt = updatedAt;
            this.Username = username;
            this.UserMetadata = userMetadata;
            this.Locale = locale;
            this.UserId = userId;
            this.LastIp = lastIp;
            this.LastLogin = lastLogin;
            this.LoginsCount = loginsCount;
            this.BlockedFor = blockedFor;
            this.GuardianAuthenticators = guardianAuthenticators;
        }

        /// <summary>
        ///  User&#39;s full name.
        /// </summary>
        /// <value> User&#39;s full name.</value>
        /*
        <example>Tsavo Knott</example>
        */
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// mapped from picture.URL pointing to the user&#39;s profile picture. 
        /// </summary>
        /// <value>mapped from picture.URL pointing to the user&#39;s profile picture. </value>
        /*
        <example>https://picsum.photos/200</example>
        */
        [DataMember(Name = "picture", EmitDefaultValue = false)]
        public string Picture { get; set; }

        /// <summary>
        /// Gets or Sets Email
        /// </summary>
        /*
        <example>user@pieces.app</example>
        */
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Indicates whether the user has verified their email address. Mapped from email_verified -&gt; emailVerified.
        /// </summary>
        /// <value>Indicates whether the user has verified their email address. Mapped from email_verified -&gt; emailVerified.</value>
        [DataMember(Name = "email_verified", EmitDefaultValue = true)]
        public bool EmailVerified { get; set; }

        /// <summary>
        /// User&#39;s family name.
        /// </summary>
        /// <value>User&#39;s family name.</value>
        [DataMember(Name = "family_name", EmitDefaultValue = false)]
        public string FamilyName { get; set; }

        /// <summary>
        /// User&#39;s given name. 
        /// </summary>
        /// <value>User&#39;s given name. </value>
        [DataMember(Name = "given_name", EmitDefaultValue = false)]
        public string GivenName { get; set; }

        /// <summary>
        /// Contains info retrieved from the identity provider with which the user originally authenticates.
        /// </summary>
        /// <value>Contains info retrieved from the identity provider with which the user originally authenticates.</value>
        [DataMember(Name = "identities", EmitDefaultValue = false)]
        public List<Auth0Identity> Identities { get; set; }

        /// <summary>
        /// User&#39;s nickname. 
        /// </summary>
        /// <value>User&#39;s nickname. </value>
        [DataMember(Name = "nickname", EmitDefaultValue = false)]
        public string Nickname { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updated_at", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        ///  (unique) User&#39;s username.  
        /// </summary>
        /// <value> (unique) User&#39;s username.  </value>
        [DataMember(Name = "username", EmitDefaultValue = false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets UserMetadata
        /// </summary>
        [DataMember(Name = "user_metadata", EmitDefaultValue = false)]
        public Auth0UserMetadata UserMetadata { get; set; }

        /// <summary>
        /// Gets or Sets Locale
        /// </summary>
        [DataMember(Name = "locale", EmitDefaultValue = false)]
        public string Locale { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Gets or Sets LastIp
        /// </summary>
        [DataMember(Name = "last_ip", EmitDefaultValue = false)]
        public string LastIp { get; set; }

        /// <summary>
        /// Gets or Sets LastLogin
        /// </summary>
        [DataMember(Name = "last_login", EmitDefaultValue = false)]
        public DateTime LastLogin { get; set; }

        /// <summary>
        /// Gets or Sets LoginsCount
        /// </summary>
        [DataMember(Name = "logins_count", EmitDefaultValue = false)]
        public int LoginsCount { get; set; }

        /// <summary>
        /// Gets or Sets BlockedFor
        /// </summary>
        [DataMember(Name = "blocked_for", EmitDefaultValue = false)]
        public List<string> BlockedFor { get; set; }

        /// <summary>
        /// Gets or Sets GuardianAuthenticators
        /// </summary>
        [DataMember(Name = "guardian_authenticators", EmitDefaultValue = false)]
        public List<string> GuardianAuthenticators { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Auth0User {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Picture: ").Append(Picture).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  EmailVerified: ").Append(EmailVerified).Append("\n");
            sb.Append("  FamilyName: ").Append(FamilyName).Append("\n");
            sb.Append("  GivenName: ").Append(GivenName).Append("\n");
            sb.Append("  Identities: ").Append(Identities).Append("\n");
            sb.Append("  Nickname: ").Append(Nickname).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  UserMetadata: ").Append(UserMetadata).Append("\n");
            sb.Append("  Locale: ").Append(Locale).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  LastIp: ").Append(LastIp).Append("\n");
            sb.Append("  LastLogin: ").Append(LastLogin).Append("\n");
            sb.Append("  LoginsCount: ").Append(LoginsCount).Append("\n");
            sb.Append("  BlockedFor: ").Append(BlockedFor).Append("\n");
            sb.Append("  GuardianAuthenticators: ").Append(GuardianAuthenticators).Append("\n");
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
