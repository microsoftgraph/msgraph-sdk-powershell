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
    [GraphRoute("PATCH", "/deviceManagement/deviceCompliancePolicies/{deviceCompliancePolicy-id}/scheduledActionsForRule/{deviceComplianceScheduledActionForRule-id}/scheduledActionConfigurations/{deviceComplianceActionItem-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceCompliancePolicyScheduledActionForRuleScheduledActionConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceActionItem))]
    public class UpdateMgDeviceManagementDeviceCompliancePolicyScheduledActionForRuleScheduledActionConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceComplianceScheduledActionForRuleId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 2)]
        public string DeviceComplianceActionItemId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? GracePeriodHours { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? NotificationMessageCCList { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationTemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceActionType? ActionType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceComplianceActionItemId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceActionItem();

    if (this.IsParameterBound(nameof(GracePeriodHours)))
        body.GracePeriodHours = GracePeriodHours;

    if (this.IsParameterBound(nameof(NotificationMessageCCList)))
        body.NotificationMessageCCList = NotificationMessageCCList!.ToList();

    if (this.IsParameterBound(nameof(NotificationTemplateId)))
        body.NotificationTemplateId = NotificationTemplateId;

    if (this.IsParameterBound(nameof(ActionType)))
        body.ActionType = ActionType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceActionItem? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].ScheduledActionsForRule[DeviceComplianceScheduledActionForRuleId].ScheduledActionConfigurations[DeviceComplianceActionItemId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex)
            {
                ThrowGraphRequestFailed(ex, DeviceComplianceActionItemId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceCompliancePolicies[DeviceCompliancePolicyId].ScheduledActionsForRule[DeviceComplianceScheduledActionForRuleId].ScheduledActionConfigurations[DeviceComplianceActionItemId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex)
                {
                    ThrowGraphRequestFailed(ex, DeviceComplianceActionItemId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
