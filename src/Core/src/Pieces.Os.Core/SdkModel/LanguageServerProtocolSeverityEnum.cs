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
    /// modeled of of https://microsoft.github.io/language-server-protocol/specifications/lsp/3.17/specification/#diagnosticSeverity
    /// </summary>
    /// <value>modeled of of https://microsoft.github.io/language-server-protocol/specifications/lsp/3.17/specification/#diagnosticSeverity</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum LanguageServerProtocolSeverityEnum
    {
        /// <summary>
        /// Enum ERROR for value: ERROR
        /// </summary>
        [EnumMember(Value = "ERROR")]
        ERROR = 1,

        /// <summary>
        /// Enum WARNING for value: WARNING
        /// </summary>
        [EnumMember(Value = "WARNING")]
        WARNING = 2,

        /// <summary>
        /// Enum INFORMATION for value: INFORMATION
        /// </summary>
        [EnumMember(Value = "INFORMATION")]
        INFORMATION = 3,

        /// <summary>
        /// Enum HINT for value: HINT
        /// </summary>
        [EnumMember(Value = "HINT")]
        HINT = 4
    }

}