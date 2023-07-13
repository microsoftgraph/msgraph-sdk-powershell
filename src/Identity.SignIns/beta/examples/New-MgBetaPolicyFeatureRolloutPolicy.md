### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	displayName = "PassthroughAuthentication rollout policy"
	description = "PassthroughAuthentication rollout policy"
	feature = "passthroughAuthentication"
	isEnabled = $true
	isAppliedToOrganization = $false
}

New-MgBetaPolicyFeatureRolloutPolicy -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyFeatureRolloutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

