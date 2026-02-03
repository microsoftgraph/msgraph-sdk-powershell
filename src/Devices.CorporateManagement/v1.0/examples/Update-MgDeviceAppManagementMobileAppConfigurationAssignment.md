### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.managedDeviceMobileAppConfigurationAssignment"
	target = @{
		"@odata.type" = "microsoft.graph.allLicensedUsersAssignmentTarget"
	}
}

Update-MgDeviceAppManagementMobileAppConfigurationAssignment -ManagedDeviceMobileAppConfigurationId $managedDeviceMobileAppConfigurationId -ManagedDeviceMobileAppConfigurationAssignmentId $managedDeviceMobileAppConfigurationAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagementMobileAppConfigurationAssignment Cmdlet.

