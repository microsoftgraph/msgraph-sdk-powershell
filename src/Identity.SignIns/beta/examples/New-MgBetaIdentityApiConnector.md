### Example 1: Using the New-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.basicAuthentication"
		Username = "<USERNAME>"
		Password = "<PASSWORD>"
	}
}
New-MgBetaIdentityApiConnector -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someotherapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "<password>"
	}
}
New-MgBetaIdentityApiConnector -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "Test API"
	TargetUrl = "https://someotherapi.com/api"
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "<password>"
	}
}
New-MgBetaIdentityApiConnector -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
