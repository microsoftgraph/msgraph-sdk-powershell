// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System;
using System.Text.Json.Serialization;

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    internal partial class JwtPayload
    {
        [JsonPropertyName("exp")]
        public long Exp { get; set; }

        [JsonPropertyName("aud")]
        public Uri Aud { get; set; }

        [JsonPropertyName("iss")]
        public Uri Iss { get; set; }

        [JsonPropertyName("app_displayname")]
        public string AppDisplayname { get; set; }

        [JsonPropertyName("appid")]
        public string Appid { get; set; }

        [JsonPropertyName("family_name")]
        public string FamilyName { get; set; }

        [JsonPropertyName("given_name")]
        public string GivenName { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("oid")]
        public string Oid { get; set; }

        [JsonPropertyName("scp")]
        public string Scp { get; set; }

        [JsonPropertyName("roles")]
        public string[] Roles { get; set; }

        [JsonPropertyName("tid")]
        public string Tid { get; set; }

        [JsonPropertyName("unique_name")]
        public string UniqueName { get; set; }

        [JsonPropertyName("upn")]
        public string Upn { get; set; }
    }
}
