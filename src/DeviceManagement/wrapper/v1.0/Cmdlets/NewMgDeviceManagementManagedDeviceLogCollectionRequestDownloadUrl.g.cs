#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}/createDownloadUrl")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementManagedDeviceLogCollectionRequestDownloadUrl", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.LogCollectionRequests.Item.CreateDownloadUrl.CreateDownloadUrlPostResponse))]
    public class NewMgDeviceManagementManagedDeviceLogCollectionRequestDownloadUrlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceLogCollectionResponseId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceLogCollectionResponseId, "New"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.LogCollectionRequests.Item.CreateDownloadUrl.CreateDownloadUrlPostResponse? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].LogCollectionRequests[DeviceLogCollectionResponseId].CreateDownloadUrl.PostAsCreateDownloadUrlPostResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, DeviceLogCollectionResponseId);
                return;
            }

            WriteObject(result);
        }
    }
}
