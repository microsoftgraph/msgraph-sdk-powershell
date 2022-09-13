###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "UpdateClaimsPolicy"
}
Update-MgPolicyClaimMappingPolicy -ClaimsMappingPolicyId $claimsMappingPolicyId -BodyParameter $params
```
