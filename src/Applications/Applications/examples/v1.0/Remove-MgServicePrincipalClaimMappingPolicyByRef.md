### Example 1: Using the Remove-MgServicePrincipalClaimMappingPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
Remove-MgServicePrincipalClaimMappingPolicyByRef -ServicePrincipalId $servicePrincipalId -ClaimsMappingPolicyId $claimsMappingPolicyId
```
This example shows how to use the Remove-MgServicePrincipalClaimMappingPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
