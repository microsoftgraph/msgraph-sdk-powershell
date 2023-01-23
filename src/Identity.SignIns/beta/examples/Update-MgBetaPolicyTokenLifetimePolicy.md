### Example 1: Using the Update-MgBetaPolicyTokenLifetimePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
Update-MgBetaPolicyTokenLifetimePolicy -TokenLifetimePolicyId $tokenLifetimePolicyId -BodyParameter $params
```
This example shows how to use the Update-MgBetaPolicyTokenLifetimePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
