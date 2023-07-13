### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.DirectoryManagement

$params = @{
	accountEnabled = $true
	alternativeSecurityIds = @(
		@{
			type = 99
			identityProvider = "identityProvider-value"
			key = [System.Text.Encoding]::ASCII.GetBytes("base64Y3YxN2E1MWFlYw==")
		}
	)
	approximateLastSignInDateTime = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	deviceId = "deviceId-value"
	deviceMetadata = "deviceMetadata-value"
	deviceVersion = 99
}

New-MgBetaDevice -BodyParameter $params
```
This example shows how to use the New-MgBetaDevice Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

