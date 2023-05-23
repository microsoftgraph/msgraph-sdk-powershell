### Example 1: Changing display name, targetUrl, and username &amp; password used for basic authentication

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "New Test API"
	targetUrl = "https://otherapi.com/api/endpoint"
	authenticationConfiguration = @{
		"@odata.type" = "microsoft.graph.basicAuthentication"
		username = "&lt;NEW_USERNAME&gt;"
		password = "&lt;NEW_PASSWORD&gt;"
	}
}

Update-MgBetaIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Changing API connector to use client certificate authentication

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	authenticationConfiguration = @{
		"@odata.type" = "#microsoft.graph.pkcs12Certificate"
		pkcs12Value = "eyJhbGciOiJSU0EtT0FFUCIsImVuYyI6IkEyNTZHQ00ifQ...kDJ04sJShkkgjL9Bm49plA"
		password = "secret"
	}
}

Update-MgBetaIdentityApiConnector -IdentityApiConnectorId $identityApiConnectorId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaIdentityApiConnector Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

