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
    [GraphRoute("POST", "/deviceManagement/windowsAutopilotDeploymentProfiles")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementWindowsAutopilotDeploymentProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeploymentProfile))]
    public class NewMgDeviceManagementWindowsAutopilotDeploymentProfileCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeviceNameTemplate { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EnableWhiteGlove { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ExtractHardwareHash { get; set; }

        [Parameter(Mandatory = false)]
        public bool? HardwareHashExtractionEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public string? Language { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Locale { get; set; }

        [Parameter(Mandatory = false)]
        public string? ManagementServiceAppId { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PreprovisioningAllowed { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeviceType? DeviceType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsEnrollmentStatusScreenSettings? EnrollmentStatusScreenSettings { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.OutOfBoxExperienceSetting? OutOfBoxExperienceSetting { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.OutOfBoxExperienceSettings? OutOfBoxExperienceSettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeploymentProfile();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DeviceNameTemplate)))
        body.DeviceNameTemplate = DeviceNameTemplate;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EnableWhiteGlove)))
        body.EnableWhiteGlove = EnableWhiteGlove;

    if (this.IsParameterBound(nameof(ExtractHardwareHash)))
        body.ExtractHardwareHash = ExtractHardwareHash;

    if (this.IsParameterBound(nameof(HardwareHashExtractionEnabled)))
        body.HardwareHashExtractionEnabled = HardwareHashExtractionEnabled;

    if (this.IsParameterBound(nameof(Language)))
        body.Language = Language;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Locale)))
        body.Locale = Locale;

    if (this.IsParameterBound(nameof(ManagementServiceAppId)))
        body.ManagementServiceAppId = ManagementServiceAppId;

    if (this.IsParameterBound(nameof(PreprovisioningAllowed)))
        body.PreprovisioningAllowed = PreprovisioningAllowed;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(DeviceType)))
        body.DeviceType = DeviceType;

    if (this.IsParameterBound(nameof(EnrollmentStatusScreenSettings)))
        body.EnrollmentStatusScreenSettings = EnrollmentStatusScreenSettings;

    if (this.IsParameterBound(nameof(OutOfBoxExperienceSetting)))
        body.OutOfBoxExperienceSetting = OutOfBoxExperienceSetting;

    if (this.IsParameterBound(nameof(OutOfBoxExperienceSettings)))
        body.OutOfBoxExperienceSettings = OutOfBoxExperienceSettings;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsAutopilotDeploymentProfile? result;
            try
            {
                result = client.DeviceManagement.WindowsAutopilotDeploymentProfiles.PostAsync(body, requestConfiguration =>
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
