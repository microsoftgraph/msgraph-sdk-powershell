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
    [GraphRoute("POST", "/deviceManagement/deviceEnrollmentConfigurations/{deviceEnrollmentConfiguration-id}/setPriority")]
    [Cmdlet(VerbsCommon.Set, "MgDeviceManagementDeviceEnrollmentConfigurationPriority", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class SetMgDeviceManagementDeviceEnrollmentConfigurationPriorityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceEnrollmentConfigurationId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? Priority { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceEnrollmentConfigurationId, "Set"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.DeviceManagement.DeviceEnrollmentConfigurations.Item.SetPriority.SetPriorityPostRequestBody();

    if (this.IsParameterBound(nameof(Priority)))
        body.Priority = Priority;

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DeviceEnrollmentConfigurations[DeviceEnrollmentConfigurationId].SetPriority.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceEnrollmentConfigurationId);
                return;
            }

        }
    }
}
