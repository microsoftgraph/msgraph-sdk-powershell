### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "UpdateClaimsPolicy"
}

Update-MgPolicyClaimMappingPolicy -ClaimsMappingPolicyId $claimsMappingPolicyId -BodyParameter $params
```
This example shows how to use the Get-MgPolicyClaimMappingPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

