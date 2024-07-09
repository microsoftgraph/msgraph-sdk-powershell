### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDeviceTransitiveMemberOfAsGroup -DeviceId $deviceId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'a')"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgDeviceTransitiveMemberOfAsGroup Cmdlet.

