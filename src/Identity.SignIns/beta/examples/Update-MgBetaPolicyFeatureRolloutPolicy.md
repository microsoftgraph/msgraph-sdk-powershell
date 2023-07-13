### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "PasswordHashSync Rollout Policy"
	description = "PasswordHashSync Rollout Policy"
	isEnabled = $true
	isAppliedToOrganization = $false
}

Update-MgBetaPolicyFeatureRolloutPolicy -FeatureRolloutPolicyId $featureRolloutPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

