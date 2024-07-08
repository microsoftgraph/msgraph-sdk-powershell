### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	displayName = "PassthroughAuthentication rollout policy"
	description = "PassthroughAuthentication rollout policy"
	feature = "passthroughAuthentication"
	isEnabled = $true
	isAppliedToOrganization = $false
}

New-MgPolicyFeatureRolloutPolicy -BodyParameter $params
```
This example shows how to use the New-MgPolicyFeatureRolloutPolicy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

