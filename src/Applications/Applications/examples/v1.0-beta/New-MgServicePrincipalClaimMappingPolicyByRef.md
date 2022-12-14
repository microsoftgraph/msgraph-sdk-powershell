### Example 1: Using the New-MgBetaServicePrincipalClaimMappingPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/policies/claimsMappingPolicies/cd3d9b57-0aee-4f25-8ee3-ac74ef5986a9"
}
New-MgBetaServicePrincipalClaimMappingPolicyByRef -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgBetaServicePrincipalClaimMappingPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
