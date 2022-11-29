### Example 1: Using the New-MgIdentityConditionalAccessAuthenticationContextClassReference Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Id = "c1"
	DisplayName = "Contoso medium"
	Description = "Medium protection level defined for Contoso policy"
	IsAvailable = $true
}
New-MgIdentityConditionalAccessAuthenticationContextClassReference -BodyParameter $params
```
This example shows how to use the New-MgIdentityConditionalAccessAuthenticationContextClassReference Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
