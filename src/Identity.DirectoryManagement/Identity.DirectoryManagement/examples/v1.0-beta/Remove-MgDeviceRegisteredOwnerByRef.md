### Example 1: Using the Remove-MgBetaDeviceRegisteredOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
Remove-MgBetaDeviceRegisteredOwnerByRef -DeviceId $deviceId -DirectoryObjectId $directoryObjectId
```
This example shows how to use the Remove-MgBetaDeviceRegisteredOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
