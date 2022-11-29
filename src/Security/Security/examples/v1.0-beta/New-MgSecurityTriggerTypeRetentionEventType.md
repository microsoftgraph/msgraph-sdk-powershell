### Example 1: Using the New-MgSecurityTriggerTypeRetentionEventType Cmdlet
```powershell
Import-Module Microsoft.Graph.Security
$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionEventType"
	DisplayName = "String"
	Description = "String"
	CreatedBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
}
New-MgSecurityTriggerTypeRetentionEventType -BodyParameter $params
```
This example shows how to use the New-MgSecurityTriggerTypeRetentionEventType Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
