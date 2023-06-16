### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "Contoso medium"
	description = "Medium protection level defined for Contoso policy"
	isAvailable = $true
}

Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference -AuthenticationContextClassReferenceId $authenticationContextClassReferenceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

