### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windowsPhone81CompliancePolicy"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	passwordBlockSimple = $true
	passwordExpirationDays = 
	passwordMinimumLength = 
	passwordMinutesOfInactivityBeforeLock = 
	passwordMinimumCharacterSetCount = 
	passwordRequiredType = "alphanumeric"
	passwordPreviousPasswordBlockCount = 
	passwordRequired = $true
	osMinimumVersion = "Os Minimum Version value"
	osMaximumVersion = "Os Maximum Version value"
	storageRequireEncryption = $true
}

New-MgDeviceManagementDeviceCompliancePolicy -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementDeviceCompliancePolicy Cmdlet.

