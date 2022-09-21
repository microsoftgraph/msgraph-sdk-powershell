### Example 1: Using the Get-MgDeviceUsageRights Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDeviceUsageRights -DeviceId $deviceId
```
This example shows how to use the Get-MgDeviceUsageRights Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgDeviceUsageRights Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Get-MgDeviceUsageRights -DeviceId $deviceId -Filter "state in ('active', 'suspended') and serviceIdentifier in ('ABCD')" 
```
This example shows how to use the Get-MgDeviceUsageRights Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
