### Example 1: Using the New-MgPolicyFeatureRolloutPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	DisplayName = "PassthroughAuthentication rollout policy"
	Description = "PassthroughAuthentication rollout policy"
	Feature = "passthroughAuthentication"
	IsEnabled = $true
	IsAppliedToOrganization = $false
}
New-MgPolicyFeatureRolloutPolicy -BodyParameter $params
```
This example shows how to use the New-MgPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
