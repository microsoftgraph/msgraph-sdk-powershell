### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "UpdateClaimsPolicy"
}

Update-MgBetaPolicyClaimMappingPolicy -ClaimsMappingPolicyId $claimsMappingPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaPolicyClaimMappingPolicy Cmdlet.

