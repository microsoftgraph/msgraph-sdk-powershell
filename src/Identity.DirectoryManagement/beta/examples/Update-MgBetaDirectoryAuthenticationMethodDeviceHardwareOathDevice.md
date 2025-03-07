### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	hashFunction = "hmacsha256"
}

Update-MgBetaDirectoryAuthenticationMethodDeviceHardwareOathDevice -HardwareOathTokenAuthenticationMethodDeviceId $hardwareOathTokenAuthenticationMethodDeviceId -BodyParameter $params

```
This example shows how to use the Update-MgBetaDirectoryAuthenticationMethodDeviceHardwareOathDevice Cmdlet.

