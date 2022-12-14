### Example 1: Using the Update-MgBetaGroupEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	OriginalStartTimeZone = "originalStartTimeZone-value"
	OriginalEndTimeZone = "originalEndTimeZone-value"
	ResponseStatus = @{
		Response = ""
		Time = [System.DateTime]::Parse("datetime-value")
	}
	Uid = "iCalUId-value"
	ReminderMinutesBeforeStart = 99
	IsReminderOn = $true
}
Update-MgBetaGroupEvent -GroupId $groupId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Update-MgBetaGroupEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
