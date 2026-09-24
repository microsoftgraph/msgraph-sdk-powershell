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
    [GraphRoute("PATCH", "/deviceManagement/androidForWorkEnrollmentProfiles/{androidForWorkEnrollmentProfile-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceManagementAndroidForWorkEnrollmentProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidForWorkEnrollmentProfile))]
    public class UpdateMgDeviceManagementAndroidForWorkEnrollmentProfileCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AndroidForWorkEnrollmentProfileId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public string? AccountId { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? EnrolledDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? QrCodeContent { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? TokenExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TokenValue { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.MimeContent? QrCodeImage { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AndroidForWorkEnrollmentProfileId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidForWorkEnrollmentProfile();

    if (this.IsParameterBound(nameof(AccountId)))
        body.AccountId = AccountId;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnrolledDeviceCount)))
        body.EnrolledDeviceCount = EnrolledDeviceCount;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(QrCodeContent)))
        body.QrCodeContent = QrCodeContent;

    if (this.IsParameterBound(nameof(TokenExpirationDateTime)))
        body.TokenExpirationDateTime = TokenExpirationDateTime;

    if (this.IsParameterBound(nameof(TokenValue)))
        body.TokenValue = TokenValue;

    if (this.IsParameterBound(nameof(QrCodeImage)))
        body.QrCodeImage = QrCodeImage;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidForWorkEnrollmentProfile? result;
            try
            {
                result = client.DeviceManagement.AndroidForWorkEnrollmentProfiles[AndroidForWorkEnrollmentProfileId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AndroidForWorkEnrollmentProfileId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceManagement.AndroidForWorkEnrollmentProfiles[AndroidForWorkEnrollmentProfileId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AndroidForWorkEnrollmentProfileId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
