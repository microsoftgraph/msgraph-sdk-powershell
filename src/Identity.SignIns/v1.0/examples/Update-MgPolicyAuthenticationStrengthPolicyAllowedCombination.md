### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	allowedCombinations = @(
	"password, voice"
)
}

Update-MgPolicyAuthenticationStrengthPolicyAllowedCombination -AuthenticationStrengthPolicyId $authenticationStrengthPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgPolicyAuthenticationStrengthPolicyAllowedCombination Cmdlet.

