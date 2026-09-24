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
    [GraphRoute("POST", "/deviceManagement/configurationPolicies/{deviceManagementConfigurationPolicy-id}/setEnrollmentTimeDeviceMembershipTarget")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgDeviceManagementConfigurationPolicySetEnrollmentTimeDeviceMembershipTarget", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EnrollmentTimeDeviceMembershipTargetResult))]
    public class InvokeMgDeviceManagementConfigurationPolicySetEnrollmentTimeDeviceMembershipTargetCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementConfigurationPolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EnrollmentTimeDeviceMembershipTarget[]? EnrollmentTimeDeviceMembershipTargets { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementConfigurationPolicyId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.ConfigurationPolicies.Item.SetEnrollmentTimeDeviceMembershipTarget.SetEnrollmentTimeDeviceMembershipTargetPostRequestBody();

    if (this.IsParameterBound(nameof(EnrollmentTimeDeviceMembershipTargets)))
        body.EnrollmentTimeDeviceMembershipTargets = EnrollmentTimeDeviceMembershipTargets!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.EnrollmentTimeDeviceMembershipTargetResult? result;
            try
            {
                result = client.DeviceManagement.ConfigurationPolicies[DeviceManagementConfigurationPolicyId].SetEnrollmentTimeDeviceMembershipTarget.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementConfigurationPolicyId);
                return;
            }

            WriteObject(result);
        }
    }
}
