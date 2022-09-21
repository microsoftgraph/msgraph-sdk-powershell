### Example 1: Using the Update-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	OriginalStartTimeZone = "originalStartTimeZone-value"
	OriginalEndTimeZone = "originalEndTimeZone-value"
	ResponseStatus = @{
		Response = ""
		Time = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	}
	Recurrence = $null
	Uid = "iCalUId-value"
	ReminderMinutesBeforeStart = 99
	IsOnlineMeeting = $true
	OnlineMeetingProvider = "teamsForBusiness"
	IsReminderOn = $true
	HideAttendees = $false
	Categories = @(
		"Red category"
	)
}
# A UPN can also be used as -UserId.
Update-MgUserEvent -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Update-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
