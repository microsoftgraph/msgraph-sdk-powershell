### Example 1: Using the New-MgPolicyTokenIssuancePolicy Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	Definition = @(
		"definition-value"
	)
	DisplayName = "displayName-value"
	IsOrganizationDefault = $true
}
New-MgPolicyTokenIssuancePolicy -BodyParameter $params
```
This example shows how to use the New-MgPolicyTokenIssuancePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
