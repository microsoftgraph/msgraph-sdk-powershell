### Example 1: Using the New-MgBetaDeviceManagementVirtualEndpointUserSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcUserSetting"
	DisplayName = "Example"
	SelfServiceEnabled = $false
	LocalAdminEnabled = $true
	RestorePointSetting = @{
		FrequencyInHours = 16
		UserRestoreEnabled = $true
	}
}
New-MgBetaDeviceManagementVirtualEndpointUserSetting -BodyParameter $params
```
This example shows how to use the New-MgBetaDeviceManagementVirtualEndpointUserSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
