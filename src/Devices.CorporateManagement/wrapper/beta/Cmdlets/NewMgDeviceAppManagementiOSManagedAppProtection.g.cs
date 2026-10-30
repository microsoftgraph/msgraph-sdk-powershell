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
    [GraphRoute("POST", "/deviceAppManagement/iosManagedAppProtections")]
    [Cmdlet(VerbsCommon.New, "MgDeviceAppManagementiOSManagedAppProtection", SupportsShouldProcess = true, ConfirmImpact = ConfirmImpact.Medium)]
    [OutputType(typeof(Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosManagedAppProtection))]
    public class NewMgDeviceAppManagementiOSManagedAppProtectionCommand : GraphClientCmdlet
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
        public string? AllowedIosDeviceModels { get; set; }

        [Parameter(Mandatory = false)]
        public bool? AllowWidgetContentSync { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomBrowserProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public string? CustomDialerAppProtocol { get; set; }

        [Parameter(Mandatory = false)]
        public int? DeployedAppCount { get; set; }

        [Parameter(Mandatory = false)]
        public bool? DisableProtectionOfManagedOutboundOpenInData { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ExemptedUniversalLinks { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FaceIdBlocked { get; set; }

        [Parameter(Mandatory = false)]
        public bool? FilterOpenInToOnlyManagedApps { get; set; }

        [Parameter(Mandatory = false)]
        public string[]? ManagedUniversalLinks { get; set; }

        [Parameter(Mandatory = false)]
        public string? MessagingRedirectAppUrlScheme { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumRequiredSdkVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWarningSdkVersion { get; set; }

        [Parameter(Mandatory = false)]
        public string? MinimumWipeSdkVersion { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ProtectInboundDataFromUnknownSources { get; set; }

        [Parameter(Mandatory = false)]
        public bool? ThirdPartyKeyboardsBlocked { get; set; }

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
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppRemediationAction? AppActionIfIosDeviceModelNotAllowed { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ManagedAppDataEncryptionType? AppDataEncryptionType { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.KeyValuePair[]? ExemptedAppProtocols { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.GenmojiIosManagedAppConfigurationState? GenmojiConfigurationState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.ScreenCaptureIosManagedAppConfigurationState? ScreenCaptureConfigurationState { get; set; }

        [Parameter(Mandatory = false)]
        public Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.WritingToolsIosManagedAppConfigurationState? WritingToolsConfigurationState { get; set; }






        protected override void ProcessRecord()
        {
            if (!ShouldProcess(null, "New"))
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

    if (this.IsParameterBound(nameof(AllowedIosDeviceModels)))
        body.AllowedIosDeviceModels = AllowedIosDeviceModels;

    if (this.IsParameterBound(nameof(AllowWidgetContentSync)))
        body.AllowWidgetContentSync = AllowWidgetContentSync;

    if (this.IsParameterBound(nameof(CustomBrowserProtocol)))
        body.CustomBrowserProtocol = CustomBrowserProtocol;

    if (this.IsParameterBound(nameof(CustomDialerAppProtocol)))
        body.CustomDialerAppProtocol = CustomDialerAppProtocol;

    if (this.IsParameterBound(nameof(DeployedAppCount)))
        body.DeployedAppCount = DeployedAppCount;

    if (this.IsParameterBound(nameof(DisableProtectionOfManagedOutboundOpenInData)))
        body.DisableProtectionOfManagedOutboundOpenInData = DisableProtectionOfManagedOutboundOpenInData;

    if (this.IsParameterBound(nameof(ExemptedUniversalLinks)))
        body.ExemptedUniversalLinks = ExemptedUniversalLinks!.ToList();

    if (this.IsParameterBound(nameof(FaceIdBlocked)))
        body.FaceIdBlocked = FaceIdBlocked;

    if (this.IsParameterBound(nameof(FilterOpenInToOnlyManagedApps)))
        body.FilterOpenInToOnlyManagedApps = FilterOpenInToOnlyManagedApps;

    if (this.IsParameterBound(nameof(ManagedUniversalLinks)))
        body.ManagedUniversalLinks = ManagedUniversalLinks!.ToList();

    if (this.IsParameterBound(nameof(MessagingRedirectAppUrlScheme)))
        body.MessagingRedirectAppUrlScheme = MessagingRedirectAppUrlScheme;

    if (this.IsParameterBound(nameof(MinimumRequiredSdkVersion)))
        body.MinimumRequiredSdkVersion = MinimumRequiredSdkVersion;

    if (this.IsParameterBound(nameof(MinimumWarningSdkVersion)))
        body.MinimumWarningSdkVersion = MinimumWarningSdkVersion;

    if (this.IsParameterBound(nameof(MinimumWipeSdkVersion)))
        body.MinimumWipeSdkVersion = MinimumWipeSdkVersion;

    if (this.IsParameterBound(nameof(ProtectInboundDataFromUnknownSources)))
        body.ProtectInboundDataFromUnknownSources = ProtectInboundDataFromUnknownSources;

    if (this.IsParameterBound(nameof(ThirdPartyKeyboardsBlocked)))
        body.ThirdPartyKeyboardsBlocked = ThirdPartyKeyboardsBlocked;

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

    if (this.IsParameterBound(nameof(AppActionIfIosDeviceModelNotAllowed)))
        body.AppActionIfIosDeviceModelNotAllowed = AppActionIfIosDeviceModelNotAllowed;

    if (this.IsParameterBound(nameof(AppDataEncryptionType)))
        body.AppDataEncryptionType = AppDataEncryptionType;

    if (this.IsParameterBound(nameof(ExemptedAppProtocols)))
        body.ExemptedAppProtocols = ExemptedAppProtocols!.ToList();

    if (this.IsParameterBound(nameof(GenmojiConfigurationState)))
        body.GenmojiConfigurationState = GenmojiConfigurationState;

    if (this.IsParameterBound(nameof(ScreenCaptureConfigurationState)))
        body.ScreenCaptureConfigurationState = ScreenCaptureConfigurationState;

    if (this.IsParameterBound(nameof(WritingToolsConfigurationState)))
        body.WritingToolsConfigurationState = WritingToolsConfigurationState;


        var requestAdapter = GetRequestAdapter();
        var client = new ApiClient(requestAdapter);

            Microsoft.Graph.PowerShell.Devices.CorporateManagement.Client.Models.IosManagedAppProtection? result;
            try
            {
                result = client.DeviceAppManagement.IosManagedAppProtections.PostAsync(body, requestConfiguration =>
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
