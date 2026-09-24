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
    [GraphRoute("PATCH", "/deviceManagement/depOnboardingSettings/{depOnboardingSetting-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementDepOnboardingSetting", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DepOnboardingSetting))]
    public class UpdateMgDeviceManagementDepOnboardingSettingCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string DepOnboardingSettingId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AppleIdentifier { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DataSharingConsentGranted { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSuccessfulSyncDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public int? LastSyncErrorCode { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastSyncTriggeredDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ShareTokenWithSchoolDataSyncService { get; set; }

        [Parameter(Mandatory = false)]
        public int? SyncedDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? TokenExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TokenName { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DepTokenType? TokenType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(DepOnboardingSettingId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DepOnboardingSetting();

    if (this.IsParameterBound(nameof(AppleIdentifier)))
        body.AppleIdentifier = AppleIdentifier;

    if (this.IsParameterBound(nameof(DataSharingConsentGranted)))
        body.DataSharingConsentGranted = DataSharingConsentGranted;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(LastSuccessfulSyncDateTime)))
        body.LastSuccessfulSyncDateTime = LastSuccessfulSyncDateTime;

    if (this.IsParameterBound(nameof(LastSyncErrorCode)))
        body.LastSyncErrorCode = LastSyncErrorCode;

    if (this.IsParameterBound(nameof(LastSyncTriggeredDateTime)))
        body.LastSyncTriggeredDateTime = LastSyncTriggeredDateTime;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(ShareTokenWithSchoolDataSyncService)))
        body.ShareTokenWithSchoolDataSyncService = ShareTokenWithSchoolDataSyncService;

    if (this.IsParameterBound(nameof(SyncedDeviceCount)))
        body.SyncedDeviceCount = SyncedDeviceCount;

    if (this.IsParameterBound(nameof(TokenExpirationDateTime)))
        body.TokenExpirationDateTime = TokenExpirationDateTime;

    if (this.IsParameterBound(nameof(TokenName)))
        body.TokenName = TokenName;

    if (this.IsParameterBound(nameof(TokenType)))
        body.TokenType = TokenType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.DepOnboardingSetting? result;
            try
            {
                result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, DepOnboardingSettingId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.DepOnboardingSettings[DepOnboardingSettingId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, DepOnboardingSettingId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
