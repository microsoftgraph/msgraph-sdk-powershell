### Example 1: Using the Update-MgPolicyClaimMappingPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "UpdateClaimsPolicy"
}
Update-MgPolicyClaimMappingPolicy -ClaimsMappingPolicyId $claimsMappingPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyClaimMappingPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
