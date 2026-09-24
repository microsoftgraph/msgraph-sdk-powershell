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
    [GraphRoute("POST", "/deviceManagement/deviceConfigurations/{deviceConfiguration-id}/assignedAccessMultiModeProfiles")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementDeviceConfigurationAssignedAccessMultiModeProfiles", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgDeviceManagementDeviceConfigurationAssignedAccessMultiModeProfilesCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.WindowsAssignedAccessProfile[]? AssignedAccessMultiModeProfiles { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceConfigurationId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceConfigurations.Item.AssignedAccessMultiModeProfiles.AssignedAccessMultiModeProfilesPostRequestBody();

    if (this.IsParameterBound(nameof(AssignedAccessMultiModeProfiles)))
        body.AssignedAccessMultiModeProfiles = AssignedAccessMultiModeProfiles!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DeviceConfigurations[DeviceConfigurationId].AssignedAccessMultiModeProfiles.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceConfigurationId);
                return;
            }

        }
    }
}
