### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.macOSCompliancePolicy"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	passwordRequired = $true
	passwordBlockSimple = $true
	passwordExpirationDays = 
	passwordMinimumLength = 
	passwordMinutesOfInactivityBeforeLock = 
	passwordPreviousPasswordBlockCount = 
	passwordMinimumCharacterSetCount = 
	passwordRequiredType = "alphanumeric"
	osMinimumVersion = "Os Minimum Version value"
	osMaximumVersion = "Os Maximum Version value"
	systemIntegrityProtectionEnabled = $true
	deviceThreatProtectionEnabled = $true
	deviceThreatProtectionRequiredSecurityLevel = "secured"
	storageRequireEncryption = $true
	firewallEnabled = $true
	firewallBlockAllIncoming = $true
	firewallEnableStealthMode = $true
}

New-MgDeviceManagementDeviceCompliancePolicy -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceCompliancePolicy Cmdlet.

