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
    [GraphRoute("POST", "/users/{user-id}/deviceEnrollmentConfigurations/{deviceEnrollmentConfiguration-id}/assign")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgUserDeviceEnrollmentConfigurationAssign", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgUserDeviceEnrollmentConfigurationAssignCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string UserId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceEnrollmentConfigurationId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.EnrollmentConfigurationAssignment[]? EnrollmentConfigurationAssignments { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceEnrollmentConfigurationId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Users.Item.DeviceEnrollmentConfigurations.Item.Assign.AssignPostRequestBody();

    if (this.IsParameterBound(nameof(EnrollmentConfigurationAssignments)))
        body.EnrollmentConfigurationAssignments = EnrollmentConfigurationAssignments!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.Users[UserId].DeviceEnrollmentConfigurations[DeviceEnrollmentConfigurationId].Assign.PostAsync(body, requestConfiguration =>
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
