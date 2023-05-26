### Example 1: Get a device

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDevice -DeviceId $deviceId
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a device and return only its id and extensionAttributes properties

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDevice -DeviceId $deviceId -Property "id,extensionAttributes"
```
This example shows how to use the Get-MgDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

