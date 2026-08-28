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
    [GraphRoute("POST", "/deviceManagement/virtualEndpoint/cloudPCs/{cloudPC-id}/rename")]
    [Cmdlet(VerbsCommon.Rename, "MgDeviceManagementVirtualEndpointCloudPc", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class RenameMgDeviceManagementVirtualEndpointCloudPcCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string CloudPCId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(CloudPCId, "Rename"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Administration.Client.DeviceManagement.VirtualEndpoint.CloudPCs.Item.Rename.RenamePostRequestBody();

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.VirtualEndpoint.CloudPCs[CloudPCId].Rename.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, CloudPCId);
                return;
            }

        }
    }
}
