### Example 1: Using the Update-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "New Test API"
	TargetUrl = "https://otherapi.com/api/endpoint"
	AuthenticationConfiguration = @{
		"@odata.type" = "microsoft.graph.basicAuthentication"
		Username = "<NEW_USERNAME>"
		Password = "<NEW_PASSWORD>"
	}
}
Update-MgBetaIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Update-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "secret"
	}
}
Update-MgBetaIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Update-MgBetaIdentityApiConnector Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	AuthenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		Pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		Password = "secret"
	}
}
Update-MgBetaIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
