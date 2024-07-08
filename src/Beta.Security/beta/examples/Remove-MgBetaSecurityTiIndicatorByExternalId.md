### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	value = @(
	"externalId-value1"
"externalId-value2"
)
}

Remove-MgBetaSecurityTiIndicatorByExternalId -BodyParameter $params

```
This example shows how to use the Remove-MgBetaSecurityTiIndicatorByExternalId Cmdlet.

