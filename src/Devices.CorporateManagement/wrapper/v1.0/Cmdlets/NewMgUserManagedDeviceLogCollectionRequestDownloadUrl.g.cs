#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/users/{user-id}/managedDevices/{managedDevice-id}/logCollectionRequests/{deviceLogCollectionResponse-id}/createDownloadUrl")]
    [Cmdlet(VerbsCommon.New, "MgUserManagedDeviceLogCollectionRequestDownloadUrl", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.ManagedDevices.Item.LogCollectionRequests.Item.CreateDownloadUrl.CreateDownloadUrlPostResponse))]
    public class NewMgUserManagedDeviceLogCollectionRequestDownloadUrlCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DeviceLogCollectionResponseId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceLogCollectionResponseId, "New"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.ManagedDevices.Item.LogCollectionRequests.Item.CreateDownloadUrl.CreateDownloadUrlPostResponse? result;
            try
            {
                result = client.Users[UserId].ManagedDevices[ManagedDeviceId].LogCollectionRequests[DeviceLogCollectionResponseId].CreateDownloadUrl.PostAsCreateDownloadUrlPostResponseAsync(requestConfiguration =>
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
