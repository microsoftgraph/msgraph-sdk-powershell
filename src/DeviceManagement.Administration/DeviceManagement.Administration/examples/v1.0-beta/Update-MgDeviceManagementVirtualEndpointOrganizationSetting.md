### Example 1: Using the Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcOrganizationSettings"
	EnableMEMAutoEnroll = $true
	OsVersion = "windows11"
	UserAccountType = "standardUser"
	WindowsSettings = @{
		Language = "en-US"
	}
}
Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting -BodyParameter $params
```
This example shows how to use the Update-MgBetaDeviceManagementVirtualEndpointOrganizationSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
