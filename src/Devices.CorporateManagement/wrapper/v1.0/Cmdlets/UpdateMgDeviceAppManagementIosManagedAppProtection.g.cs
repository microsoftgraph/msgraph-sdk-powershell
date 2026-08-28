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
    [GraphRoute("PATCH", "/deviceAppManagement/iosManagedAppProtections/{iosManagedAppProtection-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementiOSManagedAppProtection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosManagedAppProtection))]
    public class UpdateMgDeviceAppManagementiOSManagedAppProtectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string IosManagedAppProtectionId { get; set; } = string.Empty;

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? CreatedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Description { get; set; }

        [Parameter(Mandatory = false)]
        public string? DisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.DateTimeOffset? LastModifiedDateTime { get; set; }

        [Parameter(Mandatory = false)]
        public string? Version { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ContactSyncBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DataBackupBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DeviceComplianceRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DisableAppPinIfDevicePinIsSet { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FingerprintBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ManagedBrowserToOpenLinksRequired { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaximumPinRetries { get; set; }

        [Parameter(Mandatory = false)]
        public int? MinimumPinLength { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredAppVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWarningAppVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWarningOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? OrganizationalCredentialsRequired { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PeriodBeforePinReset { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PeriodOfflineBeforeAccessCheck { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PeriodOfflineBeforeWipeIsEnforced { get; set; }

        [Parameter(Mandatory = false)]
        public global::System.TimeSpan? PeriodOnlineBeforeAccessCheck { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PinRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PrintBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SaveAsBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SimplePinBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAssigned { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomBrowserProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeployedAppCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FaceIdBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredSdkVersion { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataStorageLocation?[]? AllowedDataStorageLocations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedBrowserType? ManagedBrowser { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPinCharacterSet? PinCharacterSet { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(IosManagedAppProtectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosManagedAppProtection();

    if (this.IsParameterBound(nameof(CreatedDateTime)))
        body.CreatedDateTime = CreatedDateTime;

    if (this.IsParameterBound(nameof(Description)))
        body.Description = Description;

    if (this.IsParameterBound(nameof(DisplayName)))
        body.DisplayName = DisplayName;

    if (this.IsParameterBound(nameof(LastModifiedDateTime)))
        body.LastModifiedDateTime = LastModifiedDateTime;

    if (this.IsParameterBound(nameof(Version)))
        body.Version = Version;

    if (this.IsParameterBound(nameof(ContactSyncBlocked)))
        body.ContactSyncBlocked = ContactSyncBlocked;

    if (this.IsParameterBound(nameof(DataBackupBlocked)))
        body.DataBackupBlocked = DataBackupBlocked;

    if (this.IsParameterBound(nameof(DeviceComplianceRequired)))
        body.DeviceComplianceRequired = DeviceComplianceRequired;

    if (this.IsParameterBound(nameof(DisableAppPinIfDevicePinIsSet)))
        body.DisableAppPinIfDevicePinIsSet = DisableAppPinIfDevicePinIsSet;

    if (this.IsParameterBound(nameof(FingerprintBlocked)))
        body.FingerprintBlocked = FingerprintBlocked;

    if (this.IsParameterBound(nameof(ManagedBrowserToOpenLinksRequired)))
        body.ManagedBrowserToOpenLinksRequired = ManagedBrowserToOpenLinksRequired;

    if (this.IsParameterBound(nameof(MaximumPinRetries)))
        body.MaximumPinRetries = MaximumPinRetries;

    if (this.IsParameterBound(nameof(MinimumPinLength)))
        body.MinimumPinLength = MinimumPinLength;

    if (this.IsParameterBound(nameof(MinimumRequiredAppVersion)))
        body.MinimumRequiredAppVersion = MinimumRequiredAppVersion;

    if (this.IsParameterBound(nameof(MinimumRequiredOsVersion)))
        body.MinimumRequiredOsVersion = MinimumRequiredOsVersion;

    if (this.IsParameterBound(nameof(MinimumWarningAppVersion)))
        body.MinimumWarningAppVersion = MinimumWarningAppVersion;

    if (this.IsParameterBound(nameof(MinimumWarningOsVersion)))
        body.MinimumWarningOsVersion = MinimumWarningOsVersion;

    if (this.IsParameterBound(nameof(OrganizationalCredentialsRequired)))
        body.OrganizationalCredentialsRequired = OrganizationalCredentialsRequired;

    if (this.IsParameterBound(nameof(PeriodBeforePinReset)))
        body.PeriodBeforePinReset = PeriodBeforePinReset;

    if (this.IsParameterBound(nameof(PeriodOfflineBeforeAccessCheck)))
        body.PeriodOfflineBeforeAccessCheck = PeriodOfflineBeforeAccessCheck;

    if (this.IsParameterBound(nameof(PeriodOfflineBeforeWipeIsEnforced)))
        body.PeriodOfflineBeforeWipeIsEnforced = PeriodOfflineBeforeWipeIsEnforced;

    if (this.IsParameterBound(nameof(PeriodOnlineBeforeAccessCheck)))
        body.PeriodOnlineBeforeAccessCheck = PeriodOnlineBeforeAccessCheck;

    if (this.IsParameterBound(nameof(PinRequired)))
        body.PinRequired = PinRequired;

    if (this.IsParameterBound(nameof(PrintBlocked)))
        body.PrintBlocked = PrintBlocked;

    if (this.IsParameterBound(nameof(SaveAsBlocked)))
        body.SaveAsBlocked = SaveAsBlocked;

    if (this.IsParameterBound(nameof(SimplePinBlocked)))
        body.SimplePinBlocked = SimplePinBlocked;

    if (this.IsParameterBound(nameof(IsAssigned)))
        body.IsAssigned = IsAssigned;

    if (this.IsParameterBound(nameof(CustomBrowserProtocol)))
        body.CustomBrowserProtocol = CustomBrowserProtocol;

    if (this.IsParameterBound(nameof(DeployedAppCount)))
        body.DeployedAppCount = DeployedAppCount;

    if (this.IsParameterBound(nameof(FaceIdBlocked)))
        body.FaceIdBlocked = FaceIdBlocked;

    if (this.IsParameterBound(nameof(MinimumRequiredSdkVersion)))
        body.MinimumRequiredSdkVersion = MinimumRequiredSdkVersion;

    if (this.IsParameterBound(nameof(AllowedDataStorageLocations)))
        body.AllowedDataStorageLocations = AllowedDataStorageLocations!.ToList();

    if (this.IsParameterBound(nameof(AllowedInboundDataTransferSources)))
        body.AllowedInboundDataTransferSources = AllowedInboundDataTransferSources;

    if (this.IsParameterBound(nameof(AllowedOutboundClipboardSharingLevel)))
        body.AllowedOutboundClipboardSharingLevel = AllowedOutboundClipboardSharingLevel;

    if (this.IsParameterBound(nameof(AllowedOutboundDataTransferDestinations)))
        body.AllowedOutboundDataTransferDestinations = AllowedOutboundDataTransferDestinations;

    if (this.IsParameterBound(nameof(ManagedBrowser)))
        body.ManagedBrowser = ManagedBrowser;

    if (this.IsParameterBound(nameof(PinCharacterSet)))
        body.PinCharacterSet = PinCharacterSet;

    if (this.IsParameterBound(nameof(AppDataEncryptionType)))
        body.AppDataEncryptionType = AppDataEncryptionType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosManagedAppProtection? result;
            try
            {
                result = client.DeviceAppManagement.IosManagedAppProtections[IosManagedAppProtectionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException)
            {
                ThrowGraphRequestFailed(ex, IosManagedAppProtectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.IosManagedAppProtections[IosManagedAppProtectionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException)
                {
                    ThrowGraphRequestFailed(ex, IosManagedAppProtectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
