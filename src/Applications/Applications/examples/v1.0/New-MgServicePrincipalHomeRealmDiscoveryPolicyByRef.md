###Example 1
```
Import-Module Microsoft.Graph.Applications
$params = @{
	"@odata.id" = "https://graph.microsoft.com/v1.0/policies/homeRealmDiscoveryPolicies/cd3d9b57-0aee-4f25-8ee3-ac74ef5986a9"
}
New-MgServicePrincipalHomeRealmDiscoveryPolicyByRef -ServicePrincipalId $servicePrincipalId -BodyParameter $params
```
