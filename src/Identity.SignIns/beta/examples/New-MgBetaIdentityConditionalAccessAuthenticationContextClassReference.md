### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	id = "c1"
	displayName = "Contoso medium"
	description = "Medium protection level defined for Contoso policy"
	isAvailable = $true
}

New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityConditionalAccessAuthenticationContextClassReference Cmdlet.

