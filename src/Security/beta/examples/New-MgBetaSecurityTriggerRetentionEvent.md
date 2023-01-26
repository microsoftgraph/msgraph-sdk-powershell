### Example 1: Using the New-MgBetaSecurityTriggerRetentionEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Security
$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionEvent"
	DisplayName = "String"
	Description = "String"
	EventQueries = @(
		@{
			"@odata.type" = "microsoft.graph.security.eventQueries"
		}
	)
	EventTriggerDateTime = [System.DateTime]::Parse("String (timestamp)")
	CreatedBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	EventPropagationResults = @(
		@{
			"@odata.type" = "microsoft.graph.security.eventPropagationResult"
		}
	)
	EventStatus = @{
		"@odata.type" = "microsoft.graph.security.retentionEventStatus"
	}
	LastStatusUpdateDateTime = [System.DateTime]::Parse("String (timestamp)")
}
New-MgBetaSecurityTriggerRetentionEvent -BodyParameter $params
```
This example shows how to use the New-MgBetaSecurityTriggerRetentionEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
