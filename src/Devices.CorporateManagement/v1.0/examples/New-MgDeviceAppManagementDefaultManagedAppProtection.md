### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.defaultManagedAppProtection"
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
appDataEncryptionType = "afterDeviceRestart"
screenCaptureBlocked = $true
encryptAppData = $true
disableAppEncryptionIfDeviceEncryptionIsEnabled = $true
minimumRequiredSdkVersion = "Minimum Required Sdk Version value"
customSettings = @(
	@{
		"@odata.type" = "microsoft.graph.keyValuePair"
		name = "Name value"
		value = "Value value"
	}
)
deployedAppCount = 0
minimumRequiredPatchVersion = "Minimum Required Patch Version value"
minimumWarningPatchVersion = "Minimum Warning Patch Version value"
faceIdBlocked = $true
}

New-MgDeviceAppManagementDefaultManagedAppProtection -BodyParameter $params

```
This example shows how to use the New-MgDeviceAppManagementDefaultManagedAppProtection Cmdlet.

