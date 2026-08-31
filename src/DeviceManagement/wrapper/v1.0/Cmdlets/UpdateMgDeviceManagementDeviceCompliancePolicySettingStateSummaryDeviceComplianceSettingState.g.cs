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
    [GraphRoute("PATCH", "/deviceManagement/deviceCompliancePolicySettingStateSummaries/{deviceCompliancePolicySettingStateSummary-id}/deviceComplianceSettingStates/{deviceComplianceSettingState-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDeviceCompliancePolicySettingStateSummaryDeviceComplianceSettingState", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceSettingState))]
    public class UpdateMgDeviceManagementDeviceCompliancePolicySettingStateSummaryDeviceComplianceSettingStateCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceCompliancePolicySettingStateSummaryId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string DeviceComplianceSettingStateId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ComplianceGracePeriodExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceModel { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Setting { get; set; }

        [Parameter(Mandatory = false)]
        public string? SettingName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserEmail { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.ComplianceStatus? State { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceComplianceSettingStateId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceSettingState();

    if (this.IsParameterBound(nameof(ComplianceGracePeriodExpirationDateTime)))
        body.ComplianceGracePeriodExpirationDateTime = ComplianceGracePeriodExpirationDateTime;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceModel)))
        body.DeviceModel = DeviceModel;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(Setting)))
        body.Setting = Setting;

    if (this.IsParameterBound(nameof(SettingName)))
        body.SettingName = SettingName;

    if (this.IsParameterBound(nameof(UserEmail)))
        body.UserEmail = UserEmail;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(State)))
        body.State = State;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceComplianceSettingState? result;
            try
            {
                result = client.DeviceManagement.DeviceCompliancePolicySettingStateSummaries[DeviceCompliancePolicySettingStateSummaryId].DeviceComplianceSettingStates[DeviceComplianceSettingStateId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceComplianceSettingStateId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DeviceCompliancePolicySettingStateSummaries[DeviceCompliancePolicySettingStateSummaryId].DeviceComplianceSettingStates[DeviceComplianceSettingStateId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceComplianceSettingStateId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
