### Example 1
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgServicePrincipalClaimMappingPolicyByRef -ServicePrincipalId $servicePrincipalId -ClaimsMappingPolicyId $claimsMappingPolicyId
```
