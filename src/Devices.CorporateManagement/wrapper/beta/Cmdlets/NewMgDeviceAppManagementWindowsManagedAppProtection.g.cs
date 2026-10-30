#nullable enable

using System;
using System.Linq;
using System.Management.Automation;
using System.Net.Http;
using Microsoft.Graph.Wrapper.Runtime;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client;
using Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models;
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;

namespace Microsoft.Graph.PowerShell.Devices.CorporateManagement
{
    [GraphRoute("POST", "/deviceAppManagement/windowsManagedAppProtections")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementWindowsManagedAppProtection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppProtection))]
    public class NewMgDeviceAppManagementWindowsManagedAppProtectionCommand : GraphClientCmdlet
    {


        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? RoleScopeTagIds { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeployedAppCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAssigned { get; set; }

        [Parameter(Mandatory = false)]
        public string? MaximumRequiredOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MaximumWarningOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MaximumWipeOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredAppVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredSdkVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWarningAppVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWarningOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWipeAppVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWipeOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWipeSdkVersion { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PeriodOfflineBeforeAccessCheck { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PeriodOfflineBeforeWipeIsEnforced { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PrintBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppDataTransferLocations? AllowedInboundDataTransferSourceApps { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppDataTransferLocations? AllowedOutboundDataTransferDestinationApps { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? MobileThreatDefenseRemediationAction { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppProtection();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(RoleScopeTagIds)))
        body.RoleScopeTagIds = RoleScopeTagIds!.ToList();

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(DeployedAppCount)))
        body.DeployedAppCount = DeployedAppCount;

    if (this.IsParameterBound(nameof(IsAssigned)))
        body.IsAssigned = IsAssigned;

    if (this.IsParameterBound(nameof(MaximumRequiredOsVersion)))
        body.MaximumRequiredOsVersion = MaximumRequiredOsVersion;

    if (this.IsParameterBound(nameof(MaximumWarningOsVersion)))
        body.MaximumWarningOsVersion = MaximumWarningOsVersion;

    if (this.IsParameterBound(nameof(MaximumWipeOsVersion)))
        body.MaximumWipeOsVersion = MaximumWipeOsVersion;

    if (this.IsParameterBound(nameof(MinimumRequiredAppVersion)))
        body.MinimumRequiredAppVersion = MinimumRequiredAppVersion;

    if (this.IsParameterBound(nameof(MinimumRequiredOsVersion)))
        body.MinimumRequiredOsVersion = MinimumRequiredOsVersion;

    if (this.IsParameterBound(nameof(MinimumRequiredSdkVersion)))
        body.MinimumRequiredSdkVersion = MinimumRequiredSdkVersion;

    if (this.IsParameterBound(nameof(MinimumWarningAppVersion)))
        body.MinimumWarningAppVersion = MinimumWarningAppVersion;

    if (this.IsParameterBound(nameof(MinimumWarningOsVersion)))
        body.MinimumWarningOsVersion = MinimumWarningOsVersion;

    if (this.IsParameterBound(nameof(MinimumWipeAppVersion)))
        body.MinimumWipeAppVersion = MinimumWipeAppVersion;

    if (this.IsParameterBound(nameof(MinimumWipeOsVersion)))
        body.MinimumWipeOsVersion = MinimumWipeOsVersion;

    if (this.IsParameterBound(nameof(MinimumWipeSdkVersion)))
        body.MinimumWipeSdkVersion = MinimumWipeSdkVersion;

    if (this.IsParameterBound(nameof(PeriodOfflineBeforeAccessCheck)))
        body.PeriodOfflineBeforeAccessCheck = PeriodOfflineBeforeAccessCheck;

    if (this.IsParameterBound(nameof(PeriodOfflineBeforeWipeIsEnforced)))
        body.PeriodOfflineBeforeWipeIsEnforced = PeriodOfflineBeforeWipeIsEnforced;

    if (this.IsParameterBound(nameof(PrintBlocked)))
        body.PrintBlocked = PrintBlocked;

    if (this.IsParameterBound(nameof(AllowedInboundDataTransferSourceApps)))
        body.AllowedInboundDataTransferSourceApps = AllowedInboundDataTransferSourceApps;

    if (this.IsParameterBound(nameof(AllowedInboundDataTransferSources)))
        body.AllowedInboundDataTransferSources = AllowedInboundDataTransferSources;

    if (this.IsParameterBound(nameof(AllowedOutboundClipboardSharingLevel)))
        body.AllowedOutboundClipboardSharingLevel = AllowedOutboundClipboardSharingLevel;

    if (this.IsParameterBound(nameof(AllowedOutboundDataTransferDestinationApps)))
        body.AllowedOutboundDataTransferDestinationApps = AllowedOutboundDataTransferDestinationApps;

    if (this.IsParameterBound(nameof(AllowedOutboundDataTransferDestinations)))
        body.AllowedOutboundDataTransferDestinations = AllowedOutboundDataTransferDestinations;

    if (this.IsParameterBound(nameof(AppActionIfUnableToAuthenticateUser)))
        body.AppActionIfUnableToAuthenticateUser = AppActionIfUnableToAuthenticateUser;

    if (this.IsParameterBound(nameof(MaximumAllowedDeviceThreatLevel)))
        body.MaximumAllowedDeviceThreatLevel = MaximumAllowedDeviceThreatLevel;

    if (this.IsParameterBound(nameof(MobileThreatDefenseRemediationAction)))
        body.MobileThreatDefenseRemediationAction = MobileThreatDefenseRemediationAction;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WindowsManagedAppProtection? result;
            try
            {
                result = client.DeviceAppManagement.WindowsManagedAppProtections.PostAsync(body, requestConfiguration =>
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
