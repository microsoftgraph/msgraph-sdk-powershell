### Example 1: Using the New-MgDeviceRegisteredOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.DirectoryManagement
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/directoryObjects/{id}"
}
New-MgDeviceRegisteredOwnerByRef -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the New-MgDeviceRegisteredOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
