### Example 1: Using the Remove-MgSecurityTiIndicatorMultiple Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Value = @(
		"id-value1"
		"id-value2"
	)
}
Remove-MgSecurityTiIndicatorMultiple -BodyParameter $params
```
This example shows how to use the Remove-MgSecurityTiIndicatorMultiple Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
