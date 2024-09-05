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
    /// This is the specific role of a format.
    /// </summary>
    /// <value>This is the specific role of a format.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Role
    {
        /// <summary>
        /// Enum ORIGINAL for value: ORIGINAL
        /// </summary>
        [EnumMember(Value = "ORIGINAL")]
        ORIGINAL = 1,

        /// <summary>
        /// Enum ADDITIONAL for value: ADDITIONAL
        /// </summary>
        [EnumMember(Value = "ADDITIONAL")]
        ADDITIONAL = 2,

        /// <summary>
        /// Enum BOTH for value: BOTH
        /// </summary>
        [EnumMember(Value = "BOTH")]
        BOTH = 3,

        /// <summary>
        /// Enum PREVIEW for value: PREVIEW
        /// </summary>
        [EnumMember(Value = "PREVIEW")]
        PREVIEW = 4
    }

}