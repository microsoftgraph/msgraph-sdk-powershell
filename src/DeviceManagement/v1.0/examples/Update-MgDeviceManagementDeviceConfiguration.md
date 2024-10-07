### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.sharedPCConfiguration"
	description = "Description value"
	displayName = "Display Name value"
	version = 7
	accountManagerPolicy = @{
		"@odata.type" = "microsoft.graph.sharedPCAccountManagerPolicy"
		accountDeletionPolicy = "diskSpaceThreshold"
		cacheAccountsAboveDiskFreePercentage = 
		inactiveThresholdDays = 
		removeAccountsBelowDiskFreePercentage = 
	}
	allowedAccounts = "domain"
	allowLocalStorage = $true
	disableAccountManager = $true
	disableEduPolicies = $true
	disablePowerPolicies = $true
	disableSignInOnResume = $true
	enabled = $true
	idleTimeBeforeSleepInSeconds = 
	kioskAppDisplayName = "Kiosk App Display Name value"
	kioskAppUserModelId = "Kiosk App User Model Id value"
	maintenanceStartTime = "11:59:24.7240000"
}

Update-MgDeviceManagementDeviceConfiguration -DeviceConfigurationId $deviceConfigurationId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceConfiguration Cmdlet.

