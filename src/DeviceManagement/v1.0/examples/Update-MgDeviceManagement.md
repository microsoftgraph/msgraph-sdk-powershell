### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceManagement"
}

Update-MgDeviceManagement -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagement Cmdlet.

