### Example 1: Create a token without user assignment

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Token 1"
	serialNumber = "TOTP123456"
	manufacturer = "Contoso"
	model = "Hardware Token 1000"
	secretKey = "6PJ4UKIW33NNXYZAEHQNFUFTZF7WFTFB"
	timeIntervalInSeconds = 30
	hashFunction = "hmacsha1"
}

New-MgBetaDirectoryAuthenticationMethodDeviceHardwareOathDevice -BodyParameter $params

```
This example will create a token without user assignment

### Example 2: Create a token and assign it to a user

```powershell

Import-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	displayName = "Token 1"
	serialNumber = "TOTP123456"
	manufacturer = "Contoso"
	model = "Hardware Token 1000"
	secretKey = "6PJ4UKIW33NNXYZAEHQNFUFTZF7WFTFB"
	timeIntervalInSeconds = 30
	hashFunction = "hmacsha1"
	assignTo = @{
		id = "0cadbf92-####-####-####-############"
	}
}

New-MgBetaDirectoryAuthenticationMethodDeviceHardwareOathDevice -BodyParameter $params

```
This example will create a token and assign it to a user

