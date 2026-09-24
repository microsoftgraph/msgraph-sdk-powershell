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
    [GraphRoute("POST", "/deviceManagement/deviceConfigurations/getTargetedUsersAndDevices")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDeviceConfigurationGetTargetedUsersAndDevices", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceConfigurations.GetTargetedUsersAndDevices.GetTargetedUsersAndDevicesPostResponse))]
    public class InvokeMgDeviceManagementDeviceConfigurationGetTargetedUsersAndDevicesCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string[]? DeviceConfigurationIds { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceConfigurations.GetTargetedUsersAndDevices.GetTargetedUsersAndDevicesPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceConfigurationIds)))
        body.DeviceConfigurationIds = DeviceConfigurationIds!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceConfigurations.GetTargetedUsersAndDevices.GetTargetedUsersAndDevicesPostResponse? result;
            try
            {
                result = client.DeviceManagement.DeviceConfigurations.GetTargetedUsersAndDevices.PostAsGetTargetedUsersAndDevicesPostResponseAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, null);
                return;
            }

            WriteObject(result);
        }
    }
}
