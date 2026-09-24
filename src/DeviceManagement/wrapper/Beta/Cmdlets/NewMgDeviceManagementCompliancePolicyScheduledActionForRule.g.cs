#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement
{
    [GraphRoute("POST", "/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy-id}/scheduledActionsForRule")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementCompliancePolicyScheduledActionForRule", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceScheduledActionForRule))]
    public class NewMgDeviceManagementCompliancePolicyScheduledActionForRuleCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementCompliancePolicyId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? RuleName { get; set; }







        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementCompliancePolicyId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceScheduledActionForRule();

    if (this.IsParameterBound(nameof(RuleName)))
        body.RuleName = RuleName;



        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceScheduledActionForRule? result;
            try
            {
                result = client.DeviceManagement.CompliancePolicies[DeviceManagementCompliancePolicyId].ScheduledActionsForRule.PostAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, body);
                return;
            }

            WriteObject(result);
        }
    }
}
