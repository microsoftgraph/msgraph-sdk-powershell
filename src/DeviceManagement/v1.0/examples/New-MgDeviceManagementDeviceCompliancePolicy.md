### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windows10MobileCompliancePolicy"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	passwordRequired = $true
	passwordBlockSimple = $true
	passwordMinimumLength = 
	passwordMinimumCharacterSetCount = 
	passwordRequiredType = "alphanumeric"
	passwordPreviousPasswordBlockCount = 
	passwordExpirationDays = 
	passwordMinutesOfInactivityBeforeLock = 
	passwordRequireToUnlockFromIdle = $true
	osMinimumVersion = "Os Minimum Version value"
	osMaximumVersion = "Os Maximum Version value"
	earlyLaunchAntiMalwareDriverEnabled = $true
	bitLockerEnabled = $true
	secureBootEnabled = $true
	codeIntegrityEnabled = $true
	storageRequireEncryption = $true
}

New-MgDeviceManagementDeviceCompliancePolicy -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceCompliancePolicy Cmdlet.

