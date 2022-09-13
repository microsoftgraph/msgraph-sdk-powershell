###Example 1
```
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
Update-MgPolicyTokenLifetimePolicy -TokenLifetimePolicyId $tokenLifetimePolicyId -BodyParameter $params
```
