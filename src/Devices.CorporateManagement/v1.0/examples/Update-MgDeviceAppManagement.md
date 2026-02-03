### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Devices.CorporateManagement

$params = @{
	"@odata.type" = "#microsoft.graph.deviceAppManagement"
}

Update-MgDeviceAppManagement -BodyParameter $params

```
This example shows how to use the Update-MgDeviceAppManagement Cmdlet.

