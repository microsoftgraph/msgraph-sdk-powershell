### Example 1: Using the Update-MgGroupEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
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
Update-MgGroupEvent -GroupId $groupId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Update-MgGroupEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
