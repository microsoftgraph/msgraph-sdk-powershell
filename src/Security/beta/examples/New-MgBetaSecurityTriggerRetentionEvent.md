### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Security

$params = @{
	"@odata.type" = "#microsoft.graph.security.retentionEvent"
	displayName = "String"
	description = "String"
	eventQueries = @(
		@{
			"@odata.type" = "microsoft.graph.security.eventQuery"
		}
	)
	eventTriggerDateTime = [System.DateTime]::Parse("String (timestamp)")
	createdBy = @{
		"@odata.type" = "microsoft.graph.identitySet"
	}
	eventPropagationResults = @(
		@{
			"@odata.type" = "microsoft.graph.security.eventPropagationResult"
		}
	)
	eventStatus = @{
		"@odata.type" = "microsoft.graph.security.retentionEventStatus"
	}
	lastStatusUpdateDateTime = [System.DateTime]::Parse("String (timestamp)")
}

New-MgBetaSecurityTriggerRetentionEvent -BodyParameter $params

```
This example shows how to use the New-MgBetaSecurityTriggerRetentionEvent Cmdlet.

