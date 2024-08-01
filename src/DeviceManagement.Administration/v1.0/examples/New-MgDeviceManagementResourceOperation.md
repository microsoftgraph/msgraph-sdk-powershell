### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.resourceOperation"
	resourceName = "Resource Name value"
	actionName = "Action Name value"
	description = "Description value"
}

New-MgDeviceManagementResourceOperation -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementResourceOperation Cmdlet.

