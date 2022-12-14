### Example 1: Using the Remove-MgBetaSecurityTiIndicatorByExternalId Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	Value = @(
		"externalId-value1"
		"externalId-value2"
	)
}
Remove-MgBetaSecurityTiIndicatorByExternalId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaSecurityTiIndicatorByExternalId Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
