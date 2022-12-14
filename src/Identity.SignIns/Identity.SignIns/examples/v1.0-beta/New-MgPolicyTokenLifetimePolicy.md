### Example 1: Using the New-MgBetaPolicyTokenLifetimePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
New-MgBetaPolicyTokenLifetimePolicy -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyTokenLifetimePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
