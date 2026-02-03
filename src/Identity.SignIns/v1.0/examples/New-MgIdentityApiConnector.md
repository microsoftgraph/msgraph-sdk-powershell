### Example 1: Create an API connector with basic authentication

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Test API"
	targetUrl = "https://someapi.com/api"
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.basicAuthentication"
		username = "MyUsername"
		password = "MyPassword"
	}
}

New-MgIdentityApiConnector -BodyParameter $params

```
This example will create an api connector with basic authentication

### Example 2: Create an API connector with client certificate authentication

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Test API"
	targetUrl = "https://someotherapi.com/api"
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		password = "CertificatePassword"
	}
}

New-MgIdentityApiConnector -BodyParameter $params

```
This example will create an api connector with client certificate authentication

