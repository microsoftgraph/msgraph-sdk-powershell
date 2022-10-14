### Example 1: Using the Update-MgDeviceManagementVirtualEndpointUserSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcUserSetting"
	DisplayName = "Example"
	SelfServiceEnabled = $true
	RestorePointSetting = @{
		FrequencyInHours = 16
		UserRestoreEnabled = $true
	}
	LocalAdminEnabled = $false
}
Update-MgDeviceManagementVirtualEndpointUserSetting -CloudPcUserSettingId $cloudPcUserSettingId -BodyParameter $params
```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointUserSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
