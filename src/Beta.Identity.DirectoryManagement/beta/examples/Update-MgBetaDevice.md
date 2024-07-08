### Example 1: Update the accountEnabled property of a device

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	accountEnabled = $false
}

Update-MgBetaDevice -DeviceId $deviceId -BodyParameter $params

```
This example will update the accountenabled property of a device

### Example 2:  Write extensionAttributes on a device

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	extensionAttributes = @{
		extensionAttribute1 = "BYOD-Device"
	}
}

Update-MgBetaDevice -DeviceId $deviceId -BodyParameter $params

```
This example will  write extensionattributes on a device

