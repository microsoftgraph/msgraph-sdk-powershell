### Example 1: Using the Update-MgBetaDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	ExtensionAttributes = @{
		ExtensionAttribute1 = "BYOD-Device"
	}
}
Update-MgBetaDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	AccountEnabled = $false
}
Update-MgBetaDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
