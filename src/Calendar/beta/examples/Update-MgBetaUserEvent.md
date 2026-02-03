### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	originalStartTimeZone = "originalStartTimeZone-value"
	originalEndTimeZone = "originalEndTimeZone-value"
	responseStatus = @{
		response = ""
		time = [System.DateTime]::Parse("2016-10-19T10:37:00Z")
	}
	recurrence = $null
	uid = "iCalUId-value"
	reminderMinutesBeforeStart = 99
	isOnlineMeeting = $true
	onlineMeetingProvider = "teamsForBusiness"
	isReminderOn = $true
	hideAttendees = $false
	categories = @(
		"Red category"
	)
}

# A UPN can also be used as -UserId.
Update-MgBetaUserEvent -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserEvent Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

