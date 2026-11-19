### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.autoAuditingConfiguration"
	isAutomatic = $true
}

Update-MgSecurityIdentitySettingAutoAuditingConfiguration -BodyParameter $params

```
This example shows how to use the Update-MgSecurityIdentitySettingAutoAuditingConfiguration Cmdlet.

