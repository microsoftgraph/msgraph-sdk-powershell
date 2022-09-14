### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
Remove-MgDeviceRegisteredOwnerByRef -DeviceId $deviceId -DirectoryObjectId $directoryObjectId
```
