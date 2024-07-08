### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	allowedCombinations = @(
	"password, voice"
)
}

Update-MgBetaPolicyAuthenticationStrengthPolicyAllowedCombination -AuthenticationStrengthPolicyId $authenticationStrengthPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyAuthenticationStrengthPolicyAllowedCombination Cmdlet.

