### Example 1: Using the Remove-MgDeviceRegisteredOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Remove-MgDeviceRegisteredOwnerByRef -DeviceId $deviceId -DirectoryObjectId $directoryObjectId
```
This example shows how to use the Remove-MgDeviceRegisteredOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
