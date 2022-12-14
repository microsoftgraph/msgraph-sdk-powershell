### Example 1: Using the New-MgBetaSecurityTriggerTypeRetentionEventType Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionEventType"
	DisplayName = "String"
	Description = "String"
	CreatedBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
}
New-MgBetaSecurityTriggerTypeRetentionEventType -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityTriggerTypeRetentionEventType Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
