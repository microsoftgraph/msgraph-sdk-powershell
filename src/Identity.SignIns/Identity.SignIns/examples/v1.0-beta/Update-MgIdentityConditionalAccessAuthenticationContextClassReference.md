### Example 1: Using the Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Value = @(
	)
}
Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference -AuthenticationContextClassReferenceId $authenticationContextClassReferenceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaIdentityConditionalAccessAuthenticationContextClassReference Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
