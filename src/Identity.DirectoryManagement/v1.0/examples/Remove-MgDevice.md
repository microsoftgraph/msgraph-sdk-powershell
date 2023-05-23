### Example 1: Update the accountEnabled property of a device

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
	accountEnabled = $false
}

Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Remove-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2:  Write extensionAttributes on a device

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

$params = @{
}

Update-MgDevice -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the Remove-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

