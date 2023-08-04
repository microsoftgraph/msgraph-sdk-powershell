### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	accountEnabled = $false
}

Update-MgBetaDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

