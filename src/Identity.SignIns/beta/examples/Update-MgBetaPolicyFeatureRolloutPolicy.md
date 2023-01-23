### Example 1: Using the Update-MgBetaPolicyFeatureRolloutPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	DisplayName = "PasswordHashSync Rollout Policy"
	Description = "PasswordHashSync Rollout Policy"
	IsEnabled = $true
	IsAppliedToOrganization = $false
}
Update-MgBetaPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
