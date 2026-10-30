#nullable enable

using System;
using System.Collections.Generic;
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
    [GraphRoute("GET", "/users/{user-id}/managedDevices/{managedDevice-id}/getFileVaultKey()")]
    [Cmdlet(VerbsCommon.Get, "MgUserManagedDeviceGetFileVaultKey")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.ManagedDevices.Item.GetFileVaultKey.GetFileVaultKeyGetResponse))]
    public class GetMgUserManagedDeviceGetFileVaultKeyCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.ManagedDevices.Item.GetFileVaultKey.GetFileVaultKeyGetResponse? result;
            try
            {
                result = client.Users[UserId].ManagedDevices[ManagedDeviceId].GetFileVaultKey.GetAsGetFileVaultKeyGetResponseAsync(requestConfiguration =>
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
