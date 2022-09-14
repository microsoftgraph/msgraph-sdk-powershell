### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "secret"
	}
}
Update-MgIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "New Test API"
	TargetUrl = "https://otherapi.com/api/endpoint"
	AuthenticationConfiguration = @{
		"@odata.type" = "microsoft.graph.basicAuthentication"
		Username = "<NEW_USERNAME>"
		Password = "<NEW_PASSWORD>"
	}
}
Update-MgIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "secret"
	}
}
Update-MgIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
