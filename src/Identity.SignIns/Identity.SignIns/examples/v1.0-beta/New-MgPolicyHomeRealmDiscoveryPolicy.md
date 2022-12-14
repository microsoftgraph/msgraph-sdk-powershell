### Example 1: Using the New-MgBetaPolicyHomeRealmDiscoveryPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
New-MgBetaPolicyHomeRealmDiscoveryPolicy -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyHomeRealmDiscoveryPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
