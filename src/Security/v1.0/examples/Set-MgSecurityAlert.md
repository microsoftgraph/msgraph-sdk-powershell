### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "microsoft.graph.security.alertComment"
	comment = "Demo for docs"
}

Set-MgSecurityAlert -AlertId $alertId -BodyParameter $params

```
This example shows how to use the Set-MgSecurityAlert Cmdlet.

