### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windows81GeneralConfiguration"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	accountsBlockAddingNonMicrosoftAccountEmail = $true
	applyOnlyToWindows81 = $true
	browserBlockAutofill = $true
	browserBlockAutomaticDetectionOfIntranetSites = $true
	browserBlockEnterpriseModeAccess = $true
	browserBlockJavaScript = $true
	browserBlockPlugins = $true
	browserBlockPopups = $true
	browserBlockSendingDoNotTrackHeader = $true
	browserBlockSingleWordEntryOnIntranetSites = $true
	browserRequireSmartScreen = $true
	browserEnterpriseModeSiteListLocation = "Browser Enterprise Mode Site List Location value"
	browserInternetSecurityLevel = "medium"
	browserIntranetSecurityLevel = "low"
	browserLoggingReportLocation = "Browser Logging Report Location value"
	browserRequireHighSecurityForRestrictedSites = $true
	browserRequireFirewall = $true
	browserRequireFraudWarning = $true
	browserTrustedSitesSecurityLevel = "low"
	cellularBlockDataRoaming = $true
	diagnosticsBlockDataSubmission = $true
	passwordBlockPicturePasswordAndPin = $true
	passwordExpirationDays = 
	passwordMinimumLength = 
	passwordMinutesOfInactivityBeforeScreenTimeout = 
	passwordMinimumCharacterSetCount = 
	passwordPreviousPasswordBlockCount = 
	passwordRequiredType = "alphanumeric"
	passwordSignInFailureCountBeforeFactoryReset = 
	storageRequireDeviceEncryption = $true
	updatesRequireAutomaticUpdates = $true
	userAccountControlSettings = "alwaysNotify"
	workFoldersUrl = "https://example.com/workFoldersUrl/"
}

New-MgDeviceManagementDeviceConfiguration -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceConfiguration Cmdlet.

