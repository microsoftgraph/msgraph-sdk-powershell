### Example 1: Using the Update-MgPolicyTokenLifetimePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
Update-MgPolicyTokenLifetimePolicy -TokenLifetimePolicyId $tokenLifetimePolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyTokenLifetimePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
