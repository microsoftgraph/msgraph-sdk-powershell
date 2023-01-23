### Example 1: Using the Remove-MgBetaServicePrincipalClaimMappingPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
Remove-MgBetaServicePrincipalClaimMappingPolicyByRef -ServicePrincipalId $servicePrincipalId -ClaimsMappingPolicyId $claimsMappingPolicyId
```
This example shows how to use the Remove-MgBetaServicePrincipalClaimMappingPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
