### Example 1: Update the accountEnabled property of a device

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	accountEnabled = $false
}

Update-MgDevice -DeviceId $deviceId -BodyParameter $params

```
This example will update the accountenabled property of a device

### Example 2:  Write extensionAttributes on a device

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	"extensionAttribute1" = "Value1"
	"extensionAttribute2" = "Value2"
}

Update-MgDevice -DeviceId $deviceId -BodyParameter $params

```
This example will  write extensionattributes on a device

