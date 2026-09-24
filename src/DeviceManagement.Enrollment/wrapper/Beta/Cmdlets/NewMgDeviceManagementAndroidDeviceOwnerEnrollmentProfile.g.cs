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
    [GraphRoute("POST", "/deviceManagement/androidDeviceOwnerEnrollmentProfiles")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementAndroidDeviceOwnerEnrollmentProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidDeviceOwnerEnrollmentProfile))]
    public class NewMgDeviceManagementAndroidDeviceOwnerEnrollmentProfileCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public string? AccountId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ConfigureWifi { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceNameTemplate { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public int? EnrolledDeviceCount { get; set; }

        [Parameter(Mandatory = false)]
        public int? EnrollmentTokenUsageCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsTeamsDeviceProfile { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? QrCodeContent { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? TokenCreationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? TokenExpirationDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? TokenValue { get; set; }

        [Parameter(Mandatory = false)]
        public bool? WifiHidden { get; set; }

        [Parameter(Mandatory = false)]
        public string? WifiPassword { get; set; }

        [Parameter(Mandatory = false)]
        public string? WifiSsid { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidDeviceOwnerEnrollmentMode? EnrollmentMode { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidDeviceOwnerEnrollmentTokenType? EnrollmentTokenType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.MimeContent? QrCodeImage { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AospWifiSecurityType? WifiSecurityType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidDeviceOwnerEnrollmentProfile();

    if (this.IsParameterBound(nameof(AccountId)))
        body.AccountId = AccountId;

    if (this.IsParameterBound(nameof(ConfigureWifi)))
        body.ConfigureWifi = ConfigureWifi;

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DeviceNameTemplate)))
        body.DeviceNameTemplate = DeviceNameTemplate;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnrolledDeviceCount)))
        body.EnrolledDeviceCount = EnrolledDeviceCount;

    if (this.IsParameterBound(nameof(EnrollmentTokenUsageCount)))
        body.EnrollmentTokenUsageCount = EnrollmentTokenUsageCount;

    if (this.IsParameterBound(nameof(IsTeamsDeviceProfile)))
        body.IsTeamsDeviceProfile = IsTeamsDeviceProfile;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(QrCodeContent)))
        body.QrCodeContent = QrCodeContent;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(TokenCreationDateTime)))
        body.TokenCreationDateTime = TokenCreationDateTime;

    if (this.IsParameterBound(nameof(TokenExpirationDateTime)))
        body.TokenExpirationDateTime = TokenExpirationDateTime;

    if (this.IsParameterBound(nameof(TokenValue)))
        body.TokenValue = TokenValue;

    if (this.IsParameterBound(nameof(WifiHidden)))
        body.WifiHidden = WifiHidden;

    if (this.IsParameterBound(nameof(WifiPassword)))
        body.WifiPassword = WifiPassword;

    if (this.IsParameterBound(nameof(WifiSsid)))
        body.WifiSsid = WifiSsid;

    if (this.IsParameterBound(nameof(EnrollmentMode)))
        body.EnrollmentMode = EnrollmentMode;

    if (this.IsParameterBound(nameof(EnrollmentTokenType)))
        body.EnrollmentTokenType = EnrollmentTokenType;

    if (this.IsParameterBound(nameof(QrCodeImage)))
        body.QrCodeImage = QrCodeImage;

    if (this.IsParameterBound(nameof(WifiSecurityType)))
        body.WifiSecurityType = WifiSecurityType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.AndroidDeviceOwnerEnrollmentProfile? result;
            try
            {
                result = client.DeviceManagement.AndroidDeviceOwnerEnrollmentProfiles.PostAsync(body, requestConfiguration =>
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
