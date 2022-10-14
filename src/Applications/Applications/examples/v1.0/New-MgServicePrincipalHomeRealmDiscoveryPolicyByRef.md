### Example 1: Using the New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/policies/homeRealmDiscoveryPolicies/cd3d9b57-0aee-4f25-8ee3-ac74ef5986a9"
}
New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
