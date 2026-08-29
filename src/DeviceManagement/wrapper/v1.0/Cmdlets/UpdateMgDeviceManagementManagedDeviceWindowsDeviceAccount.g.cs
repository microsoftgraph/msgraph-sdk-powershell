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
    [GraphRoute("POST", "/deviceManagement/managedDevices/{managedDevice-id}/updateWindowsDeviceAccount")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementManagedDeviceWindowsDeviceAccount", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class UpdateMgDeviceManagementManagedDeviceWindowsDeviceAccountCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.UpdateWindowsDeviceAccountActionParameter? UpdateWindowsDeviceAccountActionParameter { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Update"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ManagedDevices.Item.UpdateWindowsDeviceAccount.UpdateWindowsDeviceAccountPostRequestBody();

    if (this.IsParameterBound(nameof(UpdateWindowsDeviceAccountActionParameter)))
        body.UpdateWindowsDeviceAccountActionParameter = UpdateWindowsDeviceAccountActionParameter;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.ManagedDevices[ManagedDeviceId].UpdateWindowsDeviceAccount.PostAsync(body, requestConfiguration =>
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
