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
Update-MgPolicyActivityBasedTimeoutPolicy -ActivityBasedTimeoutPolicyId $activityBasedTimeoutPolicyId -BodyParameter $params
```
