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
    [GraphRoute("POST", "/deviceManagement/managedDevices/{managedDevice-id}/windowsDefenderScan")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgScanDeviceManagementManagedDeviceWindowsDefender", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgScanDeviceManagementManagedDeviceWindowsDefenderCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? QuickScan { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.WindowsDefenderScan.WindowsDefenderScanPostRequestBody();

    if (this.IsParameterBound(nameof(QuickScan)))
        body.QuickScan = QuickScan;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.ManagedDevices[ManagedDeviceId].WindowsDefenderScan.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }

        }
    }
}
