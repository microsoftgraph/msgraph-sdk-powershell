### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDeviceTransitiveMemberOfAsGroup -DeviceId $deviceId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'a')"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaDeviceTransitiveMemberOfAsGroup Cmdlet.

