### Example 1: Changing display name, targetUrl, and username & password used for basic authentication

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "New Test API"
	targetUrl = "https://otherapi.com/api/endpoint"
	authenticationConfiguration = @{
		"@odata.type" = "microsoft.graph.basicAuthentication"
		username = "<NEW_USERNAME>"
		password = "<NEW_PASSWORD>"
	}
}

Update-MgIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params

```
This example shows changing display name, targeturl, and username & password used for basic authentication

### Example 2: Changing API connector to use client certificate authentication

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		password = "secret"
	}
}

Update-MgIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params

```
This example shows changing api connector to use client certificate authentication

