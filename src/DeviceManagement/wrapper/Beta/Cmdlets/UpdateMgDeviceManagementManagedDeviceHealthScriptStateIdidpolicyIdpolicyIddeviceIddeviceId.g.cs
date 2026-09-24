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
    [GraphRoute("PATCH", "/deviceManagement/managedDevices/{managedDevice-id}/deviceHealthScriptStates/id='{id}',policyId='{policyId}',deviceId='{deviceId}'")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementManagedDeviceHealthScriptStateIdidpolicyIdpolicyIddeviceIddeviceId", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptPolicyState))]
    public class UpdateMgDeviceManagementManagedDeviceHealthScriptStateIdidpolicyIdpolicyIddeviceIddeviceIdCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string ManagedDeviceId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string[]? AssignmentFilterIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? ExpectedStateUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastStateUpdateDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyId { get; set; }

        [Parameter(Mandatory = false)]
        public string? PolicyName { get; set; }

        [Parameter(Mandatory = false)]
        public string? PostRemediationDetectionScriptError { get; set; }

        [Parameter(Mandatory = false)]
        public string? PostRemediationDetectionScriptOutput { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreRemediationDetectionScriptError { get; set; }

        [Parameter(Mandatory = false)]
        public string? PreRemediationDetectionScriptOutput { get; set; }

        [Parameter(Mandatory = false)]
        public string? RemediationScriptError { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RunState? DetectionState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.RemediationState? RemediationState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ManagedDeviceId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptPolicyState();

    if (this.IsParameterBound(nameof(AssignmentFilterIds)))
        body.AssignmentFilterIds = AssignmentFilterIds!.ToList();

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceName)))
        body.DeviceName = DeviceName;

    if (this.IsParameterBound(nameof(ExpectedStateUpdateDateTime)))
        body.ExpectedStateUpdateDateTime = ExpectedStateUpdateDateTime;

    if (this.IsParameterBound(nameof(LastStateUpdateDateTime)))
        body.LastStateUpdateDateTime = LastStateUpdateDateTime;

    if (this.IsParameterBound(nameof(LastSyncDateTime)))
        body.LastSyncDateTime = LastSyncDateTime;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

    if (this.IsParameterBound(nameof(PolicyId)))
        body.PolicyId = PolicyId;

    if (this.IsParameterBound(nameof(PolicyName)))
        body.PolicyName = PolicyName;

    if (this.IsParameterBound(nameof(PostRemediationDetectionScriptError)))
        body.PostRemediationDetectionScriptError = PostRemediationDetectionScriptError;

    if (this.IsParameterBound(nameof(PostRemediationDetectionScriptOutput)))
        body.PostRemediationDetectionScriptOutput = PostRemediationDetectionScriptOutput;

    if (this.IsParameterBound(nameof(PreRemediationDetectionScriptError)))
        body.PreRemediationDetectionScriptError = PreRemediationDetectionScriptError;

    if (this.IsParameterBound(nameof(PreRemediationDetectionScriptOutput)))
        body.PreRemediationDetectionScriptOutput = PreRemediationDetectionScriptOutput;

    if (this.IsParameterBound(nameof(RemediationScriptError)))
        body.RemediationScriptError = RemediationScriptError;

    if (this.IsParameterBound(nameof(UserName)))
        body.UserName = UserName;

    if (this.IsParameterBound(nameof(DetectionState)))
        body.DetectionState = DetectionState;

    if (this.IsParameterBound(nameof(RemediationState)))
        body.RemediationState = RemediationState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Client.Models.DeviceHealthScriptPolicyState? result;
            try
            {
                result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].DeviceHealthScriptStates.Id='{id}',policyId='{policyId}',deviceId='{deviceId}'.PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ManagedDeviceId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.ManagedDevices[ManagedDeviceId].DeviceHealthScriptStates.Id='{id}',policyId='{policyId}',deviceId='{deviceId}'.GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ManagedDeviceId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
