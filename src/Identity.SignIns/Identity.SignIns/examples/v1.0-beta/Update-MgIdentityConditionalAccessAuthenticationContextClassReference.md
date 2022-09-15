### Example 1: Using the Update-MgIdentityConditionalAccessAuthenticationContextClassReference Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Value = @(
	)
}
Update-MgIdentityConditionalAccessAuthenticationContextClassReference -AuthenticationContextClassReferenceId $authenticationContextClassReferenceId -BodyParameter $params
```
This example shows how to use the Update-MgIdentityConditionalAccessAuthenticationContextClassReference Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
