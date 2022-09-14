### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.basicAuthentication"
		Username = "MyUsername"
		Password = "MyPassword"
	}
}
New-MgIdentityApiConnector -BodyParameter $params
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someotherapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "CertificatePassword"
	}
}
New-MgIdentityApiConnector -BodyParameter $params
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someotherapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "CertificatePassword"
	}
}
New-MgIdentityApiConnector -BodyParameter $params
```
