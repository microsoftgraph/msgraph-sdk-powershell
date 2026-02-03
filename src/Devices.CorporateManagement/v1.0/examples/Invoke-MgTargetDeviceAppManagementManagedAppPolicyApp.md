### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	apps = @(
		@{
			"@odata.type" = "#microsoft.graph.managedMobileApp"
			mobileAppIdentifier = @{
				"@odata.type" = "microsoft.graph.androidMobileAppIdentifier"
				packageId = "Package Id value"
			}
			id = "0a129715-9715-0a12-1597-120a1597120a"
			version = "Version value"
		}
	)
}

Invoke-MgTargetDeviceAppManagementManagedAppPolicyApp -ManagedAppPolicyId $managedAppPolicyId -BodyParameter $params

```
This example shows how to use the Invoke-MgTargetDeviceAppManagementManagedAppPolicyApp Cmdlet.

