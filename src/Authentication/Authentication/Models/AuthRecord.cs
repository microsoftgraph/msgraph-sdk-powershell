// ------------------------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All Rights Reserved.  Licensed under the MIT License.  See License in the project root for license information.
// ------------------------------------------------------------------------------

using System.Text.Json;
using System.Threading;
using Microsoft.Identity.Client;

namespace Microsoft.Graph.PowerShell.Authentication
{
    public class AuthRecord : IAuthRecord
    {
        public AccountId AccountId { get; set; }
        public string Authority { get; set; }
        public string ClientId { get; set; }
        public string HomeAccountId { get; set; }
        public string TenantId { get; set; }
        public string Username { get; set; }
        public string Version { get; set; }  = "1.0";
        public async System.Threading.Tasks.Task SerializeAsync (System.IO.Stream stream, CancellationToken cancellationToken = default)
        {
            using (var json = new Utf8JsonWriter(stream))
            {
                json.WriteStartObject();

                json.WriteString(JsonEncodedText.Encode("username"), Username);

                json.WriteString(JsonEncodedText.Encode("authority"), Authority);

                json.WriteString(JsonEncodedText.Encode("homeAccountId"), HomeAccountId);

                json.WriteString(JsonEncodedText.Encode("tenantId"), TenantId);

                json.WriteString(JsonEncodedText.Encode("clientId"), ClientId);

                json.WriteString(JsonEncodedText.Encode("version"), Version);

                json.WriteEndObject();

                await json.FlushAsync(cancellationToken).ConfigureAwait(false);
            }
        }
    }
}