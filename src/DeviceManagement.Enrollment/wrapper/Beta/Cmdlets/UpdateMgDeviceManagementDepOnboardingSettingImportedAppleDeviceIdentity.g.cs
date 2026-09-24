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
    [GraphRoute("PATCH", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}/importedAppleDeviceIdentities/{importedAppleDeviceIdentity-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentity", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedAppleDeviceIdentity))]
    public class UpdateMgDeviceManagementDepOnboardingSettingImportedAppleDeviceIdentityCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;
        [Parameter(Mandatory = true, Position = 1)]
        public string ImportedAppleDeviceIdentityId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsDeleted { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsSupervised { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastContactedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? RequestedEnrollmentProfileAssignmentDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? RequestedEnrollmentProfileId { get; set; }

        [Parameter(Mandatory = false)]
        public string? SerialNumber { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DiscoverySource? DiscoverySource { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.EnrollmentState? EnrollmentState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.Platform? Platform { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(ImportedAppleDeviceIdentityId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedAppleDeviceIdentity();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(IsDeleted)))
        body.IsDeleted = IsDeleted;

    if (this.IsParameterBound(nameof(IsSupervised)))
        body.IsSupervised = IsSupervised;

    if (this.IsParameterBound(nameof(LastContactedDateTime)))
        body.LastContactedDateTime = LastContactedDateTime;

    if (this.IsParameterBound(nameof(RequestedEnrollmentProfileAssignmentDateTime)))
        body.RequestedEnrollmentProfileAssignmentDateTime = RequestedEnrollmentProfileAssignmentDateTime;

    if (this.IsParameterBound(nameof(RequestedEnrollmentProfileId)))
        body.RequestedEnrollmentProfileId = RequestedEnrollmentProfileId;

    if (this.IsParameterBound(nameof(SerialNumber)))
        body.SerialNumber = SerialNumber;

    if (this.IsParameterBound(nameof(DiscoverySource)))
        body.DiscoverySource = DiscoverySource;

    if (this.IsParameterBound(nameof(EnrollmentState)))
        body.EnrollmentState = EnrollmentState;

    if (this.IsParameterBound(nameof(Platform)))
        body.Platform = Platform;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.ImportedAppleDeviceIdentity? result;
            try
            {
                result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].ImportedAppleDeviceIdentities[ImportedAppleDeviceIdentityId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, ImportedAppleDeviceIdentityId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].ImportedAppleDeviceIdentities[ImportedAppleDeviceIdentityId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, ImportedAppleDeviceIdentityId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
