### Example 1: Using the Remove-MgBetaSecurityTiIndicatorMultiple Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Value = @(
		"id-value1"
		"id-value2"
	)
}
Remove-MgBetaSecurityTiIndicatorMultiple -BodyParameter $params
```
This example shows how to use the Remove-MgBetaSecurityTiIndicatorMultiple Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
