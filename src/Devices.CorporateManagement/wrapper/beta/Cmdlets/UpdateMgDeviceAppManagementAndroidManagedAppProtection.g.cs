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
    [GraphRoute("PATCH", "/deviceAppManagement/androidManagedAppProtections/{androidManagedAppProtection-id}")]
    [Cmdlet(VerbsData.Update, "MgDeviceAppManagementAndroidManagedAppProtection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AndroidManagedAppProtection))]
    public class UpdateMgDeviceAppManagementAndroidManagedAppProtectionCommand : GraphClientCmdlet
    {
        [Parameter(Mandatory = true, Position = 0)]
        public string AndroidManagedAppProtectionId { get; set; } = string.Empty;

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
        public int? AllowedOutboundClipboardSharingExceptionLength { get; set; }

        [Parameter(Mandatory = false)]
        public bool? BlockDataIngestionIntoOrganizationDocuments { get; set; }

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
        public global::System.TimeSpan? GracePeriodToBlockAppsDuringOffClockHours { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ManagedBrowserToOpenLinksRequired { get; set; }

        [Parameter(Mandatory = false)]
        public int? MaximumPinRetries { get; set; }

        [Parameter(Mandatory = false)]
        public string? MaximumRequiredOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MaximumWarningOsVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MaximumWipeOsVersion { get; set; }

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
        public string? MinimumWipeAppVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWipeOsVersion { get; set; }

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
        public global::System.TimeSpan? PinRequiredInsteadOfBiometricTimeout { get; set; }

        [Parameter(Mandatory = false)]
        public int? PreviousPinBlockCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? PrintBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SaveAsBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? SimplePinBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? IsAssigned { get; set; }

        [Parameter(Mandatory = false)]
        public string? AllowedAndroidDeviceManufacturers { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? AllowedAndroidDeviceModels { get; set; }

        [Parameter(Mandatory = false)]
        public bool? BiometricAuthenticationBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public int? BlockAfterCompanyPortalUpdateDeferralInDays { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ConnectToVpnOnLaunch { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomBrowserDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomBrowserPackageId { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomDialerAppDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomDialerAppPackageId { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeployedAppCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DeviceLockRequired { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DisableAppEncryptionIfDeviceEncryptionIsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? EncryptAppData { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FingerprintAndBiometricEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public bool? KeyboardsRestricted { get; set; }

        [Parameter(Mandatory = false)]
        public string? MessagingRedirectAppDisplayName { get; set; }

        [Parameter(Mandatory = false)]
        public string? MessagingRedirectAppPackageId { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredCompanyPortalVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredPatchVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWarningCompanyPortalVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWarningPatchVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWipeCompanyPortalVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWipePatchVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RequireClass3Biometrics { get; set; }

        [Parameter(Mandatory = false)]
        public bool? RequirePinAfterBiometricChange { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ScreenCaptureBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public int? WarnAfterCompanyPortalUpdateDeferralInDays { get; set; }

        [Parameter(Mandatory = false)]
        public int? WipeAfterCompanyPortalUpdateDeferralInDays { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataIngestionLocation?[]? AllowedDataIngestionLocations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataStorageLocation?[]? AllowedDataStorageLocations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataTransferLevel? AllowedInboundDataTransferSources { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppClipboardSharingLevel? AllowedOutboundClipboardSharingLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataTransferLevel? AllowedOutboundDataTransferDestinations { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfDeviceComplianceRequired { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfMaximumPinRetriesExceeded { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfUnableToAuthenticateUser { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPhoneNumberRedirectLevel? DialerRestrictionLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedBrowserType? ManagedBrowser { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDeviceThreatLevel? MaximumAllowedDeviceThreatLevel { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MobileThreatDefensePartnerPriority? MobileThreatDefensePartnerPriority { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? MobileThreatDefenseRemediationAction { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppNotificationRestriction? NotificationRestriction { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPinCharacterSet? PinCharacterSet { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.MessagingRedirectAppType? ProtectedMessagingRedirectAppType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppPurviewEvaluationRequirement? PurviewContentEvaluationRequired { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.TargetedManagedAppGroupType? AppGroupType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AppManagementLevel? TargetedAppManagementLevels { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfAccountIsClockedOut { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfAndroidDeviceManufacturerNotAllowed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfAndroidDeviceModelNotAllowed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfAndroidSafetyNetAppsVerificationFailed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfAndroidSafetyNetDeviceAttestationFailed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfDeveloperOptionsEnabled { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfDeviceLockNotSet { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanHigh { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanLow { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfDevicePasscodeComplexityLessThanMedium { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfSamsungKnoxAttestationRequired { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.KeyValuePair[]? ApprovedKeyboards { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.KeyValuePair[]? ExemptedAppPackages { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AndroidManagedAppSafetyNetAppsVerificationType? RequiredAndroidSafetyNetAppsVerificationType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AndroidManagedAppSafetyNetDeviceAttestationType? RequiredAndroidSafetyNetDeviceAttestationType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AndroidManagedAppSafetyNetEvaluationType? RequiredAndroidSafetyNetEvaluationType { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(AndroidManagedAppProtectionId, "Update"))
                return;

            var body = new Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AndroidManagedAppProtection();

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

    if (this.IsParameterBound(nameof(AllowedOutboundClipboardSharingExceptionLength)))
        body.AllowedOutboundClipboardSharingExceptionLength = AllowedOutboundClipboardSharingExceptionLength;

    if (this.IsParameterBound(nameof(BlockDataIngestionIntoOrganizationDocuments)))
        body.BlockDataIngestionIntoOrganizationDocuments = BlockDataIngestionIntoOrganizationDocuments;

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

    if (this.IsParameterBound(nameof(GracePeriodToBlockAppsDuringOffClockHours)))
        body.GracePeriodToBlockAppsDuringOffClockHours = GracePeriodToBlockAppsDuringOffClockHours;

    if (this.IsParameterBound(nameof(ManagedBrowserToOpenLinksRequired)))
        body.ManagedBrowserToOpenLinksRequired = ManagedBrowserToOpenLinksRequired;

    if (this.IsParameterBound(nameof(MaximumPinRetries)))
        body.MaximumPinRetries = MaximumPinRetries;

    if (this.IsParameterBound(nameof(MaximumRequiredOsVersion)))
        body.MaximumRequiredOsVersion = MaximumRequiredOsVersion;

    if (this.IsParameterBound(nameof(MaximumWarningOsVersion)))
        body.MaximumWarningOsVersion = MaximumWarningOsVersion;

    if (this.IsParameterBound(nameof(MaximumWipeOsVersion)))
        body.MaximumWipeOsVersion = MaximumWipeOsVersion;

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

    if (this.IsParameterBound(nameof(MinimumWipeAppVersion)))
        body.MinimumWipeAppVersion = MinimumWipeAppVersion;

    if (this.IsParameterBound(nameof(MinimumWipeOsVersion)))
        body.MinimumWipeOsVersion = MinimumWipeOsVersion;

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

    if (this.IsParameterBound(nameof(PinRequiredInsteadOfBiometricTimeout)))
        body.PinRequiredInsteadOfBiometricTimeout = PinRequiredInsteadOfBiometricTimeout;

    if (this.IsParameterBound(nameof(PreviousPinBlockCount)))
        body.PreviousPinBlockCount = PreviousPinBlockCount;

    if (this.IsParameterBound(nameof(PrintBlocked)))
        body.PrintBlocked = PrintBlocked;

    if (this.IsParameterBound(nameof(SaveAsBlocked)))
        body.SaveAsBlocked = SaveAsBlocked;

    if (this.IsParameterBound(nameof(SimplePinBlocked)))
        body.SimplePinBlocked = SimplePinBlocked;

    if (this.IsParameterBound(nameof(IsAssigned)))
        body.IsAssigned = IsAssigned;

    if (this.IsParameterBound(nameof(AllowedAndroidDeviceManufacturers)))
        body.AllowedAndroidDeviceManufacturers = AllowedAndroidDeviceManufacturers;

    if (this.IsParameterBound(nameof(AllowedAndroidDeviceModels)))
        body.AllowedAndroidDeviceModels = AllowedAndroidDeviceModels!.ToList();

    if (this.IsParameterBound(nameof(BiometricAuthenticationBlocked)))
        body.BiometricAuthenticationBlocked = BiometricAuthenticationBlocked;

    if (this.IsParameterBound(nameof(BlockAfterCompanyPortalUpdateDeferralInDays)))
        body.BlockAfterCompanyPortalUpdateDeferralInDays = BlockAfterCompanyPortalUpdateDeferralInDays;

    if (this.IsParameterBound(nameof(ConnectToVpnOnLaunch)))
        body.ConnectToVpnOnLaunch = ConnectToVpnOnLaunch;

    if (this.IsParameterBound(nameof(CustomBrowserDisplayName)))
        body.CustomBrowserDisplayName = CustomBrowserDisplayName;

    if (this.IsParameterBound(nameof(CustomBrowserPackageId)))
        body.CustomBrowserPackageId = CustomBrowserPackageId;

    if (this.IsParameterBound(nameof(CustomDialerAppDisplayName)))
        body.CustomDialerAppDisplayName = CustomDialerAppDisplayName;

    if (this.IsParameterBound(nameof(CustomDialerAppPackageId)))
        body.CustomDialerAppPackageId = CustomDialerAppPackageId;

    if (this.IsParameterBound(nameof(DeployedAppCount)))
        body.DeployedAppCount = DeployedAppCount;

    if (this.IsParameterBound(nameof(DeviceLockRequired)))
        body.DeviceLockRequired = DeviceLockRequired;

    if (this.IsParameterBound(nameof(DisableAppEncryptionIfDeviceEncryptionIsEnabled)))
        body.DisableAppEncryptionIfDeviceEncryptionIsEnabled = DisableAppEncryptionIfDeviceEncryptionIsEnabled;

    if (this.IsParameterBound(nameof(EncryptAppData)))
        body.EncryptAppData = EncryptAppData;

    if (this.IsParameterBound(nameof(FingerprintAndBiometricEnabled)))
        body.FingerprintAndBiometricEnabled = FingerprintAndBiometricEnabled;

    if (this.IsParameterBound(nameof(KeyboardsRestricted)))
        body.KeyboardsRestricted = KeyboardsRestricted;

    if (this.IsParameterBound(nameof(MessagingRedirectAppDisplayName)))
        body.MessagingRedirectAppDisplayName = MessagingRedirectAppDisplayName;

    if (this.IsParameterBound(nameof(MessagingRedirectAppPackageId)))
        body.MessagingRedirectAppPackageId = MessagingRedirectAppPackageId;

    if (this.IsParameterBound(nameof(MinimumRequiredCompanyPortalVersion)))
        body.MinimumRequiredCompanyPortalVersion = MinimumRequiredCompanyPortalVersion;

    if (this.IsParameterBound(nameof(MinimumRequiredPatchVersion)))
        body.MinimumRequiredPatchVersion = MinimumRequiredPatchVersion;

    if (this.IsParameterBound(nameof(MinimumWarningCompanyPortalVersion)))
        body.MinimumWarningCompanyPortalVersion = MinimumWarningCompanyPortalVersion;

    if (this.IsParameterBound(nameof(MinimumWarningPatchVersion)))
        body.MinimumWarningPatchVersion = MinimumWarningPatchVersion;

    if (this.IsParameterBound(nameof(MinimumWipeCompanyPortalVersion)))
        body.MinimumWipeCompanyPortalVersion = MinimumWipeCompanyPortalVersion;

    if (this.IsParameterBound(nameof(MinimumWipePatchVersion)))
        body.MinimumWipePatchVersion = MinimumWipePatchVersion;

    if (this.IsParameterBound(nameof(RequireClass3Biometrics)))
        body.RequireClass3Biometrics = RequireClass3Biometrics;

    if (this.IsParameterBound(nameof(RequirePinAfterBiometricChange)))
        body.RequirePinAfterBiometricChange = RequirePinAfterBiometricChange;

    if (this.IsParameterBound(nameof(ScreenCaptureBlocked)))
        body.ScreenCaptureBlocked = ScreenCaptureBlocked;

    if (this.IsParameterBound(nameof(WarnAfterCompanyPortalUpdateDeferralInDays)))
        body.WarnAfterCompanyPortalUpdateDeferralInDays = WarnAfterCompanyPortalUpdateDeferralInDays;

    if (this.IsParameterBound(nameof(WipeAfterCompanyPortalUpdateDeferralInDays)))
        body.WipeAfterCompanyPortalUpdateDeferralInDays = WipeAfterCompanyPortalUpdateDeferralInDays;

    if (this.IsParameterBound(nameof(AllowedDataIngestionLocations)))
        body.AllowedDataIngestionLocations = AllowedDataIngestionLocations!.ToList();

    if (this.IsParameterBound(nameof(AllowedDataStorageLocations)))
        body.AllowedDataStorageLocations = AllowedDataStorageLocations!.ToList();

    if (this.IsParameterBound(nameof(AllowedInboundDataTransferSources)))
        body.AllowedInboundDataTransferSources = AllowedInboundDataTransferSources;

    if (this.IsParameterBound(nameof(AllowedOutboundClipboardSharingLevel)))
        body.AllowedOutboundClipboardSharingLevel = AllowedOutboundClipboardSharingLevel;

    if (this.IsParameterBound(nameof(AllowedOutboundDataTransferDestinations)))
        body.AllowedOutboundDataTransferDestinations = AllowedOutboundDataTransferDestinations;

    if (this.IsParameterBound(nameof(AppActionIfDeviceComplianceRequired)))
        body.AppActionIfDeviceComplianceRequired = AppActionIfDeviceComplianceRequired;

    if (this.IsParameterBound(nameof(AppActionIfMaximumPinRetriesExceeded)))
        body.AppActionIfMaximumPinRetriesExceeded = AppActionIfMaximumPinRetriesExceeded;

    if (this.IsParameterBound(nameof(AppActionIfUnableToAuthenticateUser)))
        body.AppActionIfUnableToAuthenticateUser = AppActionIfUnableToAuthenticateUser;

    if (this.IsParameterBound(nameof(DialerRestrictionLevel)))
        body.DialerRestrictionLevel = DialerRestrictionLevel;

    if (this.IsParameterBound(nameof(ManagedBrowser)))
        body.ManagedBrowser = ManagedBrowser;

    if (this.IsParameterBound(nameof(MaximumAllowedDeviceThreatLevel)))
        body.MaximumAllowedDeviceThreatLevel = MaximumAllowedDeviceThreatLevel;

    if (this.IsParameterBound(nameof(MobileThreatDefensePartnerPriority)))
        body.MobileThreatDefensePartnerPriority = MobileThreatDefensePartnerPriority;

    if (this.IsParameterBound(nameof(MobileThreatDefenseRemediationAction)))
        body.MobileThreatDefenseRemediationAction = MobileThreatDefenseRemediationAction;

    if (this.IsParameterBound(nameof(NotificationRestriction)))
        body.NotificationRestriction = NotificationRestriction;

    if (this.IsParameterBound(nameof(PinCharacterSet)))
        body.PinCharacterSet = PinCharacterSet;

    if (this.IsParameterBound(nameof(ProtectedMessagingRedirectAppType)))
        body.ProtectedMessagingRedirectAppType = ProtectedMessagingRedirectAppType;

    if (this.IsParameterBound(nameof(PurviewContentEvaluationRequired)))
        body.PurviewContentEvaluationRequired = PurviewContentEvaluationRequired;

    if (this.IsParameterBound(nameof(AppGroupType)))
        body.AppGroupType = AppGroupType;

    if (this.IsParameterBound(nameof(TargetedAppManagementLevels)))
        body.TargetedAppManagementLevels = TargetedAppManagementLevels;

    if (this.IsParameterBound(nameof(AppActionIfAccountIsClockedOut)))
        body.AppActionIfAccountIsClockedOut = AppActionIfAccountIsClockedOut;

    if (this.IsParameterBound(nameof(AppActionIfAndroidDeviceManufacturerNotAllowed)))
        body.AppActionIfAndroidDeviceManufacturerNotAllowed = AppActionIfAndroidDeviceManufacturerNotAllowed;

    if (this.IsParameterBound(nameof(AppActionIfAndroidDeviceModelNotAllowed)))
        body.AppActionIfAndroidDeviceModelNotAllowed = AppActionIfAndroidDeviceModelNotAllowed;

    if (this.IsParameterBound(nameof(AppActionIfAndroidSafetyNetAppsVerificationFailed)))
        body.AppActionIfAndroidSafetyNetAppsVerificationFailed = AppActionIfAndroidSafetyNetAppsVerificationFailed;

    if (this.IsParameterBound(nameof(AppActionIfAndroidSafetyNetDeviceAttestationFailed)))
        body.AppActionIfAndroidSafetyNetDeviceAttestationFailed = AppActionIfAndroidSafetyNetDeviceAttestationFailed;

    if (this.IsParameterBound(nameof(AppActionIfDeveloperOptionsEnabled)))
        body.AppActionIfDeveloperOptionsEnabled = AppActionIfDeveloperOptionsEnabled;

    if (this.IsParameterBound(nameof(AppActionIfDeviceLockNotSet)))
        body.AppActionIfDeviceLockNotSet = AppActionIfDeviceLockNotSet;

    if (this.IsParameterBound(nameof(AppActionIfDevicePasscodeComplexityLessThanHigh)))
        body.AppActionIfDevicePasscodeComplexityLessThanHigh = AppActionIfDevicePasscodeComplexityLessThanHigh;

    if (this.IsParameterBound(nameof(AppActionIfDevicePasscodeComplexityLessThanLow)))
        body.AppActionIfDevicePasscodeComplexityLessThanLow = AppActionIfDevicePasscodeComplexityLessThanLow;

    if (this.IsParameterBound(nameof(AppActionIfDevicePasscodeComplexityLessThanMedium)))
        body.AppActionIfDevicePasscodeComplexityLessThanMedium = AppActionIfDevicePasscodeComplexityLessThanMedium;

    if (this.IsParameterBound(nameof(AppActionIfSamsungKnoxAttestationRequired)))
        body.AppActionIfSamsungKnoxAttestationRequired = AppActionIfSamsungKnoxAttestationRequired;

    if (this.IsParameterBound(nameof(ApprovedKeyboards)))
        body.ApprovedKeyboards = ApprovedKeyboards!.ToList();

    if (this.IsParameterBound(nameof(ExemptedAppPackages)))
        body.ExemptedAppPackages = ExemptedAppPackages!.ToList();

    if (this.IsParameterBound(nameof(RequiredAndroidSafetyNetAppsVerificationType)))
        body.RequiredAndroidSafetyNetAppsVerificationType = RequiredAndroidSafetyNetAppsVerificationType;

    if (this.IsParameterBound(nameof(RequiredAndroidSafetyNetDeviceAttestationType)))
        body.RequiredAndroidSafetyNetDeviceAttestationType = RequiredAndroidSafetyNetDeviceAttestationType;

    if (this.IsParameterBound(nameof(RequiredAndroidSafetyNetEvaluationType)))
        body.RequiredAndroidSafetyNetEvaluationType = RequiredAndroidSafetyNetEvaluationType;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.AndroidManagedAppProtection? result;
            try
            {
                result = client.DeviceAppManagement.AndroidManagedAppProtections[AndroidManagedAppProtectionId].PatchAsync(body, requestConfiguration =>
                {

                        AddRequestHeaders(requestConfiguration.Headers);
                }).GetAwaiter().GetResult();
            }
            catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
            {
                ThrowGraphRequestFailed(ex, AndroidManagedAppProtectionId);
                return;
            }


            if (result is null)
            {
                WriteVerbose("PATCH succeeded with no response body, re-fetching the updated resource.");
                try
                {
                    result = client.DeviceAppManagement.AndroidManagedAppProtections[AndroidManagedAppProtectionId].GetAsync().GetAwaiter().GetResult();
                }
                catch (Exception ex) when (ex is not PipelineStoppedException && ex is not OperationCanceledException)
                {
                    ThrowGraphRequestFailed(ex, AndroidManagedAppProtectionId);
                    return;
                }
            }
            if (result is not null)
                WriteObject(result);
        }
    }
}
