### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.windows81CompliancePolicy"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	passwordRequired = $true
	passwordBlockSimple = $true
	passwordExpirationDays = 
	passwordMinimumLength = 
	passwordMinutesOfInactivityBeforeLock = 
	passwordMinimumCharacterSetCount = 
	passwordRequiredType = "alphanumeric"
	passwordPreviousPasswordBlockCount = 
	osMinimumVersion = "Os Minimum Version value"
	osMaximumVersion = "Os Maximum Version value"
	storageRequireEncryption = $true
}

Update-MgDeviceManagementDeviceCompliancePolicy -DeviceCompliancePolicyId $deviceCompliancePolicyId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceCompliancePolicy Cmdlet.

