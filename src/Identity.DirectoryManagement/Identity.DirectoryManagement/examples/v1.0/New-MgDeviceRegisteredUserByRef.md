### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/directoryObjects/{id}"
}
New-MgDeviceRegisteredUserByRef -DeviceId $deviceId -BodyParameter $params
```
