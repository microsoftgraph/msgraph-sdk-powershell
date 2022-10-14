### Example 1: Using the Remove-MgSecurityTiIndicatorByExternalId Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	Value = @(
		"externalId-value1"
		"externalId-value2"
	)
}
Remove-MgSecurityTiIndicatorByExternalId -BodyParameter $params
```
This example shows how to use the Remove-MgSecurityTiIndicatorByExternalId Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
