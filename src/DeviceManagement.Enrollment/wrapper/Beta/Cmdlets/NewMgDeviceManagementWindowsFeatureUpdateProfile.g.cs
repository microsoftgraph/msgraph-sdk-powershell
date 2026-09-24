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
    [GraphRoute("POST", "/deviceManagement/windowsFeatureUpdateProfiles")]
    [Cmdlet(VerbsCommon.New, "MgDeviceManagementWindowsFeatureUpdateProfile", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsFeatureUpdateProfile))]
    public class NewMgDeviceManagementWindowsFeatureUpdateProfileCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? DeployableContentDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? EndOfSupportDate { get; set; }

        [Parameter(Mandatory = false)]
        public string? FeatureUpdateVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? InstallFeatureUpdatesOptional { get; set; }

        [Parameter(Mandatory = false)]
        public bool? InstallLatestWindows10OnWindows11IneligibleDevice { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsUpdateRolloutSettings? RolloutSettings { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsFeatureUpdateProfile();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(DeployableContentDisplayName)))
        body.DeployableContentDisplayName = DeployableContentDisplayName;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(EndOfSupportDate)))
        body.EndOfSupportDate = EndOfSupportDate;

    if (this.IsParameterBound(nameof(FeatureUpdateVersion)))
        body.FeatureUpdateVersion = FeatureUpdateVersion;

    if (this.IsParameterBound(nameof(InstallFeatureUpdatesOptional)))
        body.InstallFeatureUpdatesOptional = InstallFeatureUpdatesOptional;

    if (this.IsParameterBound(nameof(InstallLatestWindows10OnWindows11IneligibleDevice)))
        body.InstallLatestWindows10OnWindows11IneligibleDevice = InstallLatestWindows10OnWindows11IneligibleDevice;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(RolloutSettings)))
        body.RolloutSettings = RolloutSettings;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.DeviceManagement.Enrollment.Client.Models.WindowsFeatureUpdateProfile? result;
            try
            {
                result = client.DeviceManagement.WindowsFeatureUpdateProfiles.PostAsync(body, requestConfiguration =>
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
