### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Calendar

$params = @{
	newReminderTime = @{
		dateTime = "dateTime-value"
		timeZone = "timeZone-value"
	}
}

# A UPN can also be used as -UserId.
Invoke-MgSnoozeUserEventReminder -UserId $userId -EventId $eventId -BodyParameter $params

```
This example shows how to use the Invoke-MgSnoozeUserEventReminder Cmdlet.

