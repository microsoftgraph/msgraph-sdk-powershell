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
    [GraphRoute("POST", "/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy-id}/scheduleActionsForRules")]
    [Cmdlet(VerbsLifecycle.Invoke, "MgScheduleDeviceManagementDeviceCompliancePolicyActionForRule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]

    public class InvokeMgScheduleDeviceManagementDeviceCompliancePolicyActionForRuleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicyId { get; set; } = string.Empty;


        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceScheduledActionForRule[]? DeviceComplianceScheduledActionForRules { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceCompliancePolicyId, "Invoke"))
                return;

            var body = new global::Microsoft.Graph.PowerShell.DeviceManagement.Client.DeviceManagement.DeviceCompliancePolicies.Item.ScheduleActionsForRules.ScheduleActionsForRulesPostRequestBody();

    if (this.IsParameterBound(nameof(DeviceComplianceScheduledActionForRules)))
        body.DeviceComplianceScheduledActionForRules = DeviceComplianceScheduledActionForRules!.ToList();

        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);


            try
            {
                client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].ScheduleActionsForRules.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                })
                    .GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceCompliancePolicyId);
                return;
            }

        }
    }
}
