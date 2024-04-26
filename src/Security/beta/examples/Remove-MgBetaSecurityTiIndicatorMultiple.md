### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	value = @(
	"id-value1"
"id-value2"
)
}

Remove-MgBetaSecurityTiIndicatorMultiple -BodyParameter $params

```
This example shows how to use the Remove-MgBetaSecurityTiIndicatorMultiple Cmdlet.

