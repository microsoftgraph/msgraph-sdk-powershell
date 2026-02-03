### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "PasswordHashSync Rollout Policy"
	description = "PasswordHashSync Rollout Policy"
	isEnabled = $true
	isAppliedToOrganization = $false
}

Update-MgPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgPolicyFeatureRolloutPolicy Cmdlet.

