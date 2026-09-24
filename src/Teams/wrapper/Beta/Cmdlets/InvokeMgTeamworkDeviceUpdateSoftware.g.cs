#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Teams.Client;
using Microsoft.Graph.PowerShell.Teams.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Teams
{
    [GraphRoute("POST", "/teamwork/devices/{teamworkDevice-id}/updateSoftware")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgTeamworkDeviceUpdateSoftware", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgTeamworkDeviceUpdateSoftwareCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string TeamworkDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? SoftwareVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Teams.Client.Models.TeamworkSoftwareType? SoftwareType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(TeamworkDeviceId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Teams.Client.Teamwork.Devices.Item.UpdateSoftware.UpdateSoftwarePostRequestBody();

    if (this.IsParameterBound(nameof(SoftwareVersion)))
        body.SoftwareVersion = SoftwareVersion;
    if (this.IsParameterBound(nameof(SoftwareType)))
        body.SoftwareType = SoftwareType;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Teamwork.Devices[TeamworkDeviceId].UpdateSoftware.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, TeamworkDeviceId);
                return;
            }

        }
    }
}
