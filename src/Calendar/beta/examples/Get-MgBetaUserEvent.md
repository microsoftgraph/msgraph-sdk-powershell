### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Calendar

$params = @{
	originalStartTimeZone = "originalStartTimeZone-value"
	originalEndTimeZone = "originalEndTimeZone-value"
	responseStatus = @{
		response = ""
		time = [System.DateTime]::Parse("datetime-value")
	}
	recurrence = $null
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
This example shows how to use the Get-MgBetaBetaUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

