### Example 1: Using the New-MgPolicyTokenLifetimePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
New-MgPolicyTokenLifetimePolicy -BodyParameter $params
```
This example shows how to use the New-MgPolicyTokenLifetimePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
