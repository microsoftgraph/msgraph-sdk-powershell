### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	clientId = "ef969797-201d-4f6b-960c-e9ed5f31dab5"
	consentType = "AllPrincipals"
	resourceId = "943603e4-e787-4fe9-93d1-e30f749aae39"
	scope = "DelegatedPermissionGrant.ReadWrite.All"
}

New-MgBetaOauth2PermissionGrant -BodyParameter $params
```
This example shows how to use the New-MgBetaBetaOauth2PermissionGrant Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

