### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/directoryObjects/{id}"
}

New-MgBetaDeviceRegisteredOwnerByRef -DeviceId $deviceId -BodyParameter $params

```
This example shows how to use the New-MgBetaDeviceRegisteredOwnerByRef Cmdlet.

