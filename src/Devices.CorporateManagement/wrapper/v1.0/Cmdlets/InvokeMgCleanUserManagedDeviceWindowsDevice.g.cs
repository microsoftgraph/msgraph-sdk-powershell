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
    [GraphRoute("POST", "/users/{user-id}/managedDevices/{managedDevice-id}/cleanWindowsDevice")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgCleanUserManagedDeviceWindowsDevice", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgCleanUserManagedDeviceWindowsDeviceCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public bool? KeepUserData { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.ManagedDevices.Item.CleanWindowsDevice.CleanWindowsDevicePostRequestBody();

    if (this.IsParameterBound(nameof(KeepUserData)))
        body.KeepUserData = KeepUserData;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].ManagedDevices[ManagedDeviceId].CleanWindowsDevice.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }

        }
    }
}
