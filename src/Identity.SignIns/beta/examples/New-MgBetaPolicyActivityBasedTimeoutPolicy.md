### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	definition = @(
		"definition-value"
	)
	displayName = "displayName-value"
	isOrganizationDefault = $true
}

New-MgBetaPolicyActivityBasedTimeoutPolicy -BodyParameter $params
```
This example shows how to use the New-MgBetaPolicyActivityBasedTimeoutPolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

