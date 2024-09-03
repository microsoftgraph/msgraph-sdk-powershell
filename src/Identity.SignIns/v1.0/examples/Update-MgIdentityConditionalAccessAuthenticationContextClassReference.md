### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "Contoso medium"
	description = "Medium protection level defined for Contoso policy"
	isAvailable = $true
}

Update-MgIdentityConditionalAccessAuthenticationContextClassReference -AuthenticationContextClassReferenceId $authenticationContextClassReferenceId -BodyParameter $params

```
This example shows how to use the Update-MgIdentityConditionalAccessAuthenticationContextClassReference Cmdlet.

