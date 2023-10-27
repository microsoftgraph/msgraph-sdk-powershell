### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDeviceTransitiveMemberOf -DeviceId $deviceId
```
This example shows how to use the Get-MgDeviceTransitiveMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDeviceTransitiveMemberOfAsGroup -DeviceId $deviceId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'a')"  -ConsistencyLevel eventual
```
This example shows how to use the Get-MgDeviceTransitiveMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

