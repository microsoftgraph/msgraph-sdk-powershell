// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

namespace Microsoft.Graph.PowerShell.Authentication.Models
{
    using System;
    using Newtonsoft.Json;
    internal partial class JwtPayload
    {
        [JsonProperty("aud")]
        public Uri Aud { get; set; }

        [JsonProperty("iss")]
        public Uri Iss { get; set; }

        [JsonProperty("app_displayname")]
        public string AppDisplayname { get; set; }

        [JsonProperty("appid")]
        public string Appid { get; set; }

        [JsonProperty("family_name")]
        public string FamilyName { get; set; }

        [JsonProperty("given_name")]
        public string GivenName { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("oid")]
        public string Oid { get; set; }

        [JsonProperty("scp")]
        public string Scp { get; set; }

        [JsonProperty("roles")]
        public string[] Roles { get; set; }

        [JsonProperty("tid")]
        public string Tid { get; set; }

        [JsonProperty("unique_name")]
        public string UniqueName { get; set; }

        [JsonProperty("upn")]
        public string Upn { get; set; }
    }
}
