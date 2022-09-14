### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "PasswordHashSync Rollout Policy"
	Description = "PasswordHashSync Rollout Policy"
	IsEnabled = $true
	IsAppliedToOrganization = $false
}
Update-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params
```
