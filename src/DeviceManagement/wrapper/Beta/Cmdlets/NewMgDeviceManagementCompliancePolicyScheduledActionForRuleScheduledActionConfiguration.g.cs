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
    [GraphRoute("POST", "/deviceManagement/compliancePolicies/{deviceManagementCompliancePolicy-id}/scheduledActionsForRule/{deviceManagementComplianceScheduledActionForRule-id}/scheduledActionConfigurations")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementCompliancePolicyScheduledActionForRuleScheduledActionConfiguration", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceActionItem))]
    public class NewMgDeviceManagementCompliancePolicyScheduledActionForRuleScheduledActionConfigurationCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementCompliancePolicyId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceManagementComplianceScheduledActionForRuleId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public int? GracePeriodHours { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? NotificationMessageCCList { get; set; }

        [Parameter(Mandatory = false)]
        public string? NotificationTemplateId { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceActionType? ActionType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementComplianceScheduledActionForRuleId, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceActionItem();

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

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceManagementComplianceActionItem? result;
            try
            {
                result = client.DeviceManagement.CompliancePolicies[DeviceManagementCompliancePolicyId].ScheduledActionsForRule[DeviceManagementComplianceScheduledActionForRuleId].ScheduledActionConfigurations.PostAsync(body, requestConfiguration =>
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
