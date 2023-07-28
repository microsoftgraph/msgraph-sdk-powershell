### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "microsoft.graph.socialIdentityProvider"
	displayName = "Login with Amazon"
	identityProviderType = "Amazon"
	clientId = "56433757-cadd-4135-8431-2c9e3fd68ae8"
	clientSecret = "000000000000"
}

New-MgBetaIdentityProvider -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

