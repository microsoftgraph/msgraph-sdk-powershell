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
    [GraphRoute("POST", "/users/{user-id}/presence/setStatusMessage")]
    [Cmdlet(VerbsCommon.Set, "MgUserPresenceStatusMessage", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgUserPresenceStatusMessageCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.PresenceStatusMessage? StatusMessage { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(UserId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Users.Item.Presence.SetStatusMessage.SetStatusMessagePostRequestBody();

    if (this.IsParameterBound(nameof(StatusMessage)))
        body.StatusMessage = StatusMessage;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].Presence.SetStatusMessage.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, UserId);
                return;
            }

        }
    }
}
