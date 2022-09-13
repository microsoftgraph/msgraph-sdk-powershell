###Example 1
```
Import-Module Microsoft.Graph.Calendar
$params = @{
	OriginalStartTimeZone = "originalStartTimeZone-value"
	OriginalEndTimeZone = "originalEndTimeZone-value"
	ResponseStatus = @{
		Response = ""
		Time = [System.DateTime]::Parse("datetime-value")
	}
	Recurrence = $null
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
