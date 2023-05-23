### Example 1: Update a specific <strong>social identity provider</strong> (Azure AD or Azure AD B2C)

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	clientSecret = "1111111111111"
}

Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Remove-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Update a specific <strong>Apple identity provider</strong> (only for Azure AD B2C)

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.socialIdentityProvider"
	displayName = "Apple"
}

Update-MgIdentityProvider -IdentityProviderBaseId $identityProviderBaseId -BodyParameter $params
```
This example shows how to use the Remove-MgIdentityProvider Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

