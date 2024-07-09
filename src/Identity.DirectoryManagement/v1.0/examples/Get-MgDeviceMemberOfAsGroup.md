### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.DirectoryManagement

Get-MgDeviceMemberOfAsGroup -DeviceId $deviceId -CountVariable CountVar -Sort "displayName" -Filter "startswith(displayName, 'A')"  -ConsistencyLevel eventual 


```
This example shows how to use the Get-MgDeviceMemberOfAsGroup Cmdlet.

