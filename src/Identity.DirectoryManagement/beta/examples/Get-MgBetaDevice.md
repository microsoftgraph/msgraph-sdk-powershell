### Example 1: Get a device

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDevice -DeviceId $deviceId
```
This example shows how to use the Get-MgBetaBetaDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a device and return only its id and extensionAttributes properties

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDevice -DeviceId $deviceId -Property "id,extensionAttributes"
```
This example shows how to use the Get-MgBetaBetaDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

