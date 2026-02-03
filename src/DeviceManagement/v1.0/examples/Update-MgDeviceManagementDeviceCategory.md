### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceCategory"
	displayName = "Display Name value"
	description = "Description value"
}

Update-MgDeviceManagementDeviceCategory -DeviceCategoryId $deviceCategoryId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementDeviceCategory Cmdlet.

