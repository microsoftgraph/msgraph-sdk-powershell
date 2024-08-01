### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	definition = @(
		"definition-value"
	)
	displayName = "displayName-value"
	isOrganizationDefault = $true
}

Update-MgPolicyActivityBasedTimeoutPolicy -ActivityBasedTimeoutPolicyId $activityBasedTimeoutPolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyActivityBasedTimeoutPolicy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

