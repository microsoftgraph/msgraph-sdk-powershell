### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionEventType"
	displayName = "String"
	description = "String"
	createdBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
}

New-MgSecurityTriggerTypeRetentionEventType -BodyParameter $params

```
This example shows how to use the New-MgSecurityTriggerTypeRetentionEventType Cmdlet.

