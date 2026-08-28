#nullable enable

using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("POST", "/deviceManagement/windowsAutopilotDeviceIdentities/{windowsAutopilotDeviceIdentity-id}/unassignUserFromDevice")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUnassignDeviceManagementWindowsAutopilotDeviceIdentityUserFromDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUnassignDeviceManagementWindowsAutopilotDeviceIdentityUserFromDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsAutopilotDeviceIdentityId { get; set; } = string.Empty;








        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsAutopilotDeviceIdentityId, "Invoke"))
                return;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.WindowsAutopilotDeviceIdentities[WindowsAutopilotDeviceIdentityId].UnassignUserFromDevice.PostAsync(requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, WindowsAutopilotDeviceIdentityId);
                return;
            }

        }
    }
}
