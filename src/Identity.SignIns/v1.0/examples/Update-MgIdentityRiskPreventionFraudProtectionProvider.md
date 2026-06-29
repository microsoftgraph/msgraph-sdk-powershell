### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.arkoseFraudProtectionProvider"
	displayName = "Arkose Sign-Up Protection Updated"
}

Update-MgIdentityRiskPreventionFraudProtectionProvider -FraudProtectionProviderId $fraudProtectionProviderId -BodyParameter $params

```
This example shows how to use the Update-MgIdentityRiskPreventionFraudProtectionProvider Cmdlet.

