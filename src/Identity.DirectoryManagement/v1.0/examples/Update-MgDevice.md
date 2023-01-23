### Example 1: Using the Update-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
}
Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Update-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgDevice Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	AccountEnabled = $false
}
Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Update-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
