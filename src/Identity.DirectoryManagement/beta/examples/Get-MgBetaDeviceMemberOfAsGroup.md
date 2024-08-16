### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

Get-MgBetaDeviceMemberOfAsGroup -DeviceId $deviceId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'A')"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgBetaDeviceMemberOfAsGroup Cmdlet.

