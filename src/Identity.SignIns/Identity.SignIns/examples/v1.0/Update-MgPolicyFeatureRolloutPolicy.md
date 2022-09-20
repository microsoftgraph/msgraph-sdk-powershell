### Example 1: Using the Update-MgPolicyFeatureRolloutPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "PasswordHashSync Rollout Policy"
	Description = "PasswordHashSync Rollout Policy"
	IsEnabled = $true
	IsAppliedToOrganization = $false
}
Update-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
