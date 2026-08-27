#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.CloudCommunications.Client;
using Microsoft.Graph.PowerShell.CloudCommunications.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.CloudCommunications
{
    [GraphRoute("POST", "/users/{user-id}/presence/clearPresence")]
    [Cmdlet(VerbsCommon.Clear, "MgUserPresence", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class ClearMgUserPresenceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? SessionId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Clear"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Users.Item.Presence.ClearPresence.ClearPresencePostRequestBody();

    if (this.IsParameterBound(nameof(SessionId)))
        body.SessionId = SessionId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Presence.ClearPresence.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
