#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/deviceManagement/comanagedDevices/{managedDevice-id}/getFileVaultKey()")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementComanagedDeviceGetFileVaultKey")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ComanagedDevices.Item.GetFileVaultKey.GetFileVaultKeyGetResponse))]
    public class GetMgDeviceManagementComanagedDeviceGetFileVaultKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ComanagedDevices.Item.GetFileVaultKey.GetFileVaultKeyGetResponse? result;
            try
            {
                result = client.DeviceManagement.ComanagedDevices[ManagedDeviceId].GetFileVaultKey.GetAsGetFileVaultKeyGetResponseAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }

            WriteObject(result);
        }
    }
}
