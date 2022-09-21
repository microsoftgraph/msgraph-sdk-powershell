### Example 1: Using the New-MgDeviceRegisteredUserByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/directoryObjects/{id}"
}
New-MgDeviceRegisteredUserByRef -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the New-MgDeviceRegisteredUserByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
