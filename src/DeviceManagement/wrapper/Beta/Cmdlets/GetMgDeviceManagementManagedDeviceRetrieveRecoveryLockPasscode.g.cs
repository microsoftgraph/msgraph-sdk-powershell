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
    [GraphRoute("GET", "/deviceManagement/managedDevices/{managedDevice-id}/retrieveRecoveryLockPasscode()")]
    [Cmdlet(VerbsCommon.Get, "MgDeviceManagementManagedDeviceRetrieveRecoveryLockPasscode")]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.RetrieveRecoveryLockPasscode.RetrieveRecoveryLockPasscodeGetResponse))]
    public class GetMgDeviceManagementManagedDeviceRetrieveRecoveryLockPasscodeCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;









        protected override void ProcessRecord()
        {

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.RetrieveRecoveryLockPasscode.RetrieveRecoveryLockPasscodeGetResponse? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].RetrieveRecoveryLockPasscode.GetAsRetrieveRecoveryLockPasscodeGetResponseAsync(requestConfiguration =>
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
