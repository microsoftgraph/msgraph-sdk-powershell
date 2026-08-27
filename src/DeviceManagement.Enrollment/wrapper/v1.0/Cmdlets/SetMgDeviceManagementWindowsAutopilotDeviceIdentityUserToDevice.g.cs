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
    [GraphRoute("POST", "/deviceManagement/windowsAutopilotDeviceIdentities/{windowsAutopilotDeviceIdentity-id}/assignUserToDevice")]
    [Cmdlet(VerbsCommon.Set, "MgDeviceManagementWindowsAutopilotDeviceIdentityUserToDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgDeviceManagementWindowsAutopilotDeviceIdentityUserToDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string WindowsAutopilotDeviceIdentityId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? AddressableUserName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(WindowsAutopilotDeviceIdentityId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.WindowsAutopilotDeviceIdentities.Item.AssignUserToDevice.AssignUserToDevicePostRequestBody();

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(AddressableUserName)))
        body.AddressableUserName = AddressableUserName;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.WindowsAutopilotDeviceIdentities[WindowsAutopilotDeviceIdentityId].AssignUserToDevice.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, WindowsAutopilotDeviceIdentityId);
                return;
            }

        }
    }
}
