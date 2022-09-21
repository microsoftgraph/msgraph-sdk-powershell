### Example 1: Using the Update-MgDeviceManagementVirtualEndpointOrganizationSetting Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Administration
$params = @{
	"@odata.type" = "#microsoft.graph.cloudPcOrganizationSettings"
	EnableMEMAutoEnroll = $true
	OsVersion = "windows11"
	UserAccountType = "standardUser"
	WindowsSettings = @{
		Language = "en-US"
	}
}
Update-MgDeviceManagementVirtualEndpointOrganizationSetting -BodyParameter $params
```
This example shows how to use the Update-MgDeviceManagementVirtualEndpointOrganizationSetting Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
