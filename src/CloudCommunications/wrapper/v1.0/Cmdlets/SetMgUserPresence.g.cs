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
    [GraphRoute("POST", "/users/{user-id}/presence/setPresence")]
    [Cmdlet(VerbsCommon.Set, "MgUserPresence", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgUserPresenceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? SessionId { get; set; }

        [Parameter(Mandatory = false)]
        public string? Availability { get; set; }

        [Parameter(Mandatory = false)]
        public string? Activity { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? ExpirationDuration { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Users.Item.Presence.SetPresence.SetPresencePostRequestBody();

    if (this.IsParameterBound(nameof(SessionId)))
        body.SessionId = SessionId;

    if (this.IsParameterBound(nameof(Availability)))
        body.Availability = Availability;

    if (this.IsParameterBound(nameof(Activity)))
        body.Activity = Activity;

    if (this.IsParameterBound(nameof(ExpirationDuration)))
        body.ExpirationDuration = ExpirationDuration;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Presence.SetPresence.PostAsync(body, requestConfiguration =>
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
