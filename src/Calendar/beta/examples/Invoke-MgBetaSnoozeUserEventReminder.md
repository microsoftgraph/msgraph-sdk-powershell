### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	newReminderTime = @{
		dateTime = "2016-10-19T10:37:00Z"
		timeZone = "timeZone-value"
	}
}

# A UPN can also be used as -UserId.
Invoke-MgBetaSnoozeUserEventReminder -UserId $userId -EventId $eventId -BodyParameter $params

```
This example shows how to use the Invoke-MgBetaSnoozeUserEventReminder Cmdlet.

