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
    [GraphRoute("POST", "/communications/calls/{call-id}/changeScreenSharingRole")]
    [Cmdlet(VerbsCommon.Rename, "MgCommunicationCallScreenSharingRole", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RenameMgCommunicationCallScreenSharingRoleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CallId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.CloudCommunications.Client.Models.ScreenSharingRole? Role { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CallId, "Rename"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.CloudCommunications.Client.Communications.Calls.Item.ChangeScreenSharingRole.ChangeScreenSharingRolePostRequestBody();

    if (this.IsParameterBound(nameof(Role)))
        body.Role = Role;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Communications.Calls[CallId].ChangeScreenSharingRole.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CallId);
                return;
            }

        }
    }
}
