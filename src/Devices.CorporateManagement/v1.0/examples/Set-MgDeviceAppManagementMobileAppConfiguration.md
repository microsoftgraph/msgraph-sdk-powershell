### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	assignments = @(
		@{
			"@odata.type" = "#microsoft.graph.managedDeviceMobileAppConfigurationAssignment"
			id = "4df81c9c-1c9c-4df8-9c1c-f84d9c1cf84d"
			target = @{
				"@odata.type" = "microsoft.graph.allLicensedUsersAssignmentTarget"
			}
		}
	)
}

Set-MgDeviceAppManagementMobileAppConfiguration -ManagedDeviceMobileAppConfigurationId $managedDeviceMobileAppConfigurationId -BodyParameter $params

```
This example shows how to use the Set-MgDeviceAppManagementMobileAppConfiguration Cmdlet.

