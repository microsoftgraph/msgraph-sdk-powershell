### Example 1: Using the New-MgBetaDeviceRegisteredOwnerByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/directoryObjects/{id}"
}
New-MgBetaDeviceRegisteredOwnerByRef -DeviceId $deviceId -BodyParameter $params
```
This example shows how to use the New-MgBetaDeviceRegisteredOwnerByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
