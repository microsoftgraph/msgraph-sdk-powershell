### Example 1: Using the New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/policies/homeRealmDiscoveryPolicies/6c6f154f-cb39-4ff9-bf5b-62d5ad585cde"
}
New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
This example shows how to use the New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
