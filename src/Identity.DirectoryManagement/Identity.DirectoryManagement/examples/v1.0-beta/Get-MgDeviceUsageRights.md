### Example 1: Using the Get-MgBetaDeviceUsageRights Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Get-MgBetaDeviceUsageRights -DeviceId $deviceId
```
This example shows how to use the Get-MgBetaDeviceUsageRights Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaDeviceUsageRights Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Get-MgBetaDeviceUsageRights -DeviceId $deviceId -Filter "state in ('active', 'suspended') and serviceIdentifier in ('ABCD')" 
```
This example shows how to use the Get-MgBetaDeviceUsageRights Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
