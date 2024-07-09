### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.resourceOperation"
	resourceName = "Resource Name value"
	actionName = "Action Name value"
	description = "Description value"
}

Update-MgDeviceManagementResourceOperation -ResourceOperationId $resourceOperationId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementResourceOperation Cmdlet.

