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
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC-id}/restore")]
    [Cmdlet(VerbsData.Restore, "MgDeviceManagementVirtualEndpointCloudPc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RestoreMgDeviceManagementVirtualEndpointCloudPcCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPCId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? CloudPcSnapshotId { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPCId, "Restore"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Restore.RestorePostRequestBody();

    if (this.IsParameterBound(nameof(CloudPcSnapshotId)))
        body.CloudPcSnapshotId = CloudPcSnapshotId;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.VirtualEndpoint.CloudPCs[CloudPCId].Restore.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, CloudPCId);
                return;
            }

        }
    }
}
