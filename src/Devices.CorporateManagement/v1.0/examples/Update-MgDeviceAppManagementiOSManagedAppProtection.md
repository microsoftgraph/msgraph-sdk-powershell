### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.iosManagedAppProtection"
	displayName = "Display Name value"
	description = "Description value"
	version = "Version value"
	periodOfflineBeforeAccessCheck = "-PT17.1357909S"
	periodOnlineBeforeAccessCheck = "PT35.0018757S"
	allowedInboundDataTransferSources = "managedApps"
	allowedOutboundDataTransferDestinations = "managedApps"
	organizationalCredentialsRequired = $true
	allowedOutboundClipboardSharingLevel = "managedAppsWithPasteIn"
	dataBackupBlocked = $true
	deviceComplianceRequired = $true
	managedBrowserToOpenLinksRequired = $true
	saveAsBlocked = $true
	periodOfflineBeforeWipeIsEnforced = "-PT3M22.1587532S"
	pinRequired = $true
	maximumPinRetries = 1
	simplePinBlocked = $true
	minimumPinLength = 0
	pinCharacterSet = "alphanumericAndSymbol"
	periodBeforePinReset = "PT3M29.6631862S"
	allowedDataStorageLocations = @(
	"sharePoint"
)
contactSyncBlocked = $true
printBlocked = $true
fingerprintBlocked = $true
disableAppPinIfDevicePinIsSet = $true
minimumRequiredOsVersion = "Minimum Required Os Version value"
minimumWarningOsVersion = "Minimum Warning Os Version value"
minimumRequiredAppVersion = "Minimum Required App Version value"
minimumWarningAppVersion = "Minimum Warning App Version value"
managedBrowser = "microsoftEdge"
isAssigned = $true
appDataEncryptionType = "afterDeviceRestart"
minimumRequiredSdkVersion = "Minimum Required Sdk Version value"
deployedAppCount = 0
faceIdBlocked = $true
customBrowserProtocol = "Custom Browser Protocol value"
}

Update-MgDeviceAppManagementiOSManagedAppProtection -IosManagedAppProtectionId $iosManagedAppProtectionId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementiOSManagedAppProtection Cmdlet.

