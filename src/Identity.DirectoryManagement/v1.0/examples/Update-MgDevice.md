### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	accountEnabled = $false
}

Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Update-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

