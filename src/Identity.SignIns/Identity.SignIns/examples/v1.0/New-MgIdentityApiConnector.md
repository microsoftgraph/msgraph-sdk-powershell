### Example 1: Using the New-MgIdentityApiConnector Cmdlet
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
This example shows how to use the New-MgIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgIdentityApiConnector Cmdlet
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
This example shows how to use the New-MgIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgIdentityApiConnector Cmdlet
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
This example shows how to use the New-MgIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
