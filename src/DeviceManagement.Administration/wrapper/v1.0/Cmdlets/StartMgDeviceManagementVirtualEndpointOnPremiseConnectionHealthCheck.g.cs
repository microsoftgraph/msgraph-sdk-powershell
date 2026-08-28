#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Administration
{
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/onPremisesConnections/{cloudPcOnPremisesConnection-id}/runHealthChecks")]
    [Cmdlet(VerbsLifecycle.Start, "MgDeviceManagementVirtualEndpointOnPremiseConnectionHealthCheck", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class StartMgDeviceManagementVirtualEndpointOnPremiseConnectionHealthCheckCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPcOnPremisesConnectionId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPcOnPremisesConnectionId, "Start"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.VirtualEndpoint.OnPremisesConnections[CloudPcOnPremisesConnectionId].RunHealthChecks.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CloudPcOnPremisesConnectionId);
                return;
            }

        }
    }
}
