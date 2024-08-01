### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.managedAppPolicyDeploymentSummary"
	displayName = "Display Name value"
	configurationDeployedUserCount = 14
	lastRefreshTime = [System.DateTime]::Parse("2017-01-01T00:01:30.1240368-08:00")
	configurationDeploymentSummaryPerApp = @(
		@{
			"@odata.type" = "microsoft.graph.managedAppPolicyDeploymentSummaryPerApp"
			mobileAppIdentifier = @{
				"@odata.type" = "microsoft.graph.androidMobileAppIdentifier"
				packageId = "Package Id value"
			}
			configurationAppliedUserCount = 13
		}
	)
	version = "Version value"
}

Update-MgDeviceAppManagementiOSManagedAppProtectionDeploymentSummary -IosManagedAppProtectionId $iosManagedAppProtectionId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementiOSManagedAppProtectionDeploymentSummary Cmdlet.

