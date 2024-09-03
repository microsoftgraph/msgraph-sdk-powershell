### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.authenticationStrengthPolicy"
	displayName = "FIDO2 only"
	description = "An auth strength allowing only FIDO2 security keys."
}

Update-MgPolicyAuthenticationStrengthPolicy -AuthenticationStrengthPolicyId $authenticationStrengthPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgPolicyAuthenticationStrengthPolicy Cmdlet.

