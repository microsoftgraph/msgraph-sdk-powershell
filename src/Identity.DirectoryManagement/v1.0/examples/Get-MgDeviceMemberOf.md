### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDeviceMemberOf -DeviceId $deviceId
```
This example shows how to use the Get-MgDeviceMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDeviceMemberOfAsGroup -DeviceId $deviceId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'A')" -ConsistencyLevel eventual
```
This example shows how to use the Get-MgDeviceMemberOf Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

