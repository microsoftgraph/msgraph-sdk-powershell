#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client;
using Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.DeviceManagement.Enrollment
{
    [GraphRoute("PATCH", "/deviceManagement/autopilotEvents/{deviceManagementAutopilotEvent-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementAutopilotEvent", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DeviceManagementAutopilotEvent))]
    public class UpdateMgDeviceManagementAutopilotEventCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DeviceManagementAutopilotEventId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? AccountSetupDuration { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? DeploymentDuration { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeploymentEndDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeploymentStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? DeploymentTotalDuration { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? DeviceRegisteredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceSerialNumber { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? DeviceSetupDuration { get; set; }

        [Parameter(Mandatory = false)]
        public string? EnrollmentFailureDetails { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EnrollmentStartDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EventDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagedDeviceName { get; set; }

        [Parameter(Mandatory = false)]
        public string? OsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserId { get; set; }

        [Parameter(Mandatory = false)]
        public string? UserPrincipalName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Windows10EnrollmentCompletionPageConfigurationDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Windows10EnrollmentCompletionPageConfigurationId { get; set; }

        [Parameter(Mandatory = false)]
        public string? WindowsAutopilotDeploymentProfileDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeploymentState? AccountSetupStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeploymentState? DeploymentState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeploymentState? DeviceSetupStatus { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentState? EnrollmentState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotEnrollmentType? EnrollmentType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DeviceManagementAutopilotEventId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DeviceManagementAutopilotEvent();

    if (this.IsParameterBound(nameof(AccountSetupDuration)))
        body.AccountSetupDuration = AccountSetupDuration;

    if (this.IsParameterBound(nameof(DeploymentDuration)))
        body.DeploymentDuration = DeploymentDuration;

    if (this.IsParameterBound(nameof(DeploymentEndDateTime)))
        body.DeploymentEndDateTime = DeploymentEndDateTime;

    if (this.IsParameterBound(nameof(DeploymentStartDateTime)))
        body.DeploymentStartDateTime = DeploymentStartDateTime;

    if (this.IsParameterBound(nameof(DeploymentTotalDuration)))
        body.DeploymentTotalDuration = DeploymentTotalDuration;

    if (this.IsParameterBound(nameof(DeviceId)))
        body.DeviceId = DeviceId;

    if (this.IsParameterBound(nameof(DeviceRegisteredDateTime)))
        body.DeviceRegisteredDateTime = DeviceRegisteredDateTime;

    if (this.IsParameterBound(nameof(DeviceSerialNumber)))
        body.DeviceSerialNumber = DeviceSerialNumber;

    if (this.IsParameterBound(nameof(DeviceSetupDuration)))
        body.DeviceSetupDuration = DeviceSetupDuration;

    if (this.IsParameterBound(nameof(EnrollmentFailureDetails)))
        body.EnrollmentFailureDetails = EnrollmentFailureDetails;

    if (this.IsParameterBound(nameof(EnrollmentStartDateTime)))
        body.EnrollmentStartDateTime = EnrollmentStartDateTime;

    if (this.IsParameterBound(nameof(EventDateTime)))
        body.EventDateTime = EventDateTime;

    if (this.IsParameterBound(nameof(ManagedDeviceName)))
        body.ManagedDeviceName = ManagedDeviceName;

    if (this.IsParameterBound(nameof(OsVersion)))
        body.OsVersion = OsVersion;

    if (this.IsParameterBound(nameof(UserId)))
        body.UserId = UserId;

    if (this.IsParameterBound(nameof(UserPrincipalName)))
        body.UserPrincipalName = UserPrincipalName;

    if (this.IsParameterBound(nameof(Windows10EnrollmentCompletionPageConfigurationDisplayName)))
        body.Windows10EnrollmentCompletionPageConfigurationDisplayName = Windows10EnrollmentCompletionPageConfigurationDisplayName;

    if (this.IsParameterBound(nameof(Windows10EnrollmentCompletionPageConfigurationId)))
        body.Windows10EnrollmentCompletionPageConfigurationId = Windows10EnrollmentCompletionPageConfigurationId;

    if (this.IsParameterBound(nameof(WindowsAutopilotDeploymentProfileDisplayName)))
        body.WindowsAutopilotDeploymentProfileDisplayName = WindowsAutopilotDeploymentProfileDisplayName;

    if (this.IsParameterBound(nameof(AccountSetupStatus)))
        body.AccountSetupStatus = AccountSetupStatus;

    if (this.IsParameterBound(nameof(DeploymentState)))
        body.DeploymentState = DeploymentState;

    if (this.IsParameterBound(nameof(DeviceSetupStatus)))
        body.DeviceSetupStatus = DeviceSetupStatus;

    if (this.IsParameterBound(nameof(EnrollmentState)))
        body.EnrollmentState = EnrollmentState;

    if (this.IsParameterBound(nameof(EnrollmentType)))
        body.EnrollmentType = EnrollmentType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DeviceManagementAutopilotEvent? result;
            try
            {
                result = client.DeviceManagement.AutopilotEvents[DeviceManagementAutopilotEventId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DeviceManagementAutopilotEventId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.AutopilotEvents[DeviceManagementAutopilotEventId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DeviceManagementAutopilotEventId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
