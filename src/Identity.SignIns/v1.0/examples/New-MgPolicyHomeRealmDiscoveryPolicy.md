### Example 1: Using the New-MgPolicyHomeRealmDiscoveryPolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
New-MgPolicyHomeRealmDiscoveryPolicy -BodyParameter $params
```
This example shows how to use the New-MgPolicyHomeRealmDiscoveryPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
