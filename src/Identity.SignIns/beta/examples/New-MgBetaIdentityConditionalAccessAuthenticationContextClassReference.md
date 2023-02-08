### Example 1: Using the New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Id = "c1"
	DisplayName = "Contoso medium"
	Description = "Medium protection level defined for Contoso policy"
	IsAvailable = $true
}
New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference -BodyParameter $params
```
This example shows how to use the New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
