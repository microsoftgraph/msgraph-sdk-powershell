### Example 1
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	NewReminderTime = @{
		DateTime = "dateTime-value"
		TimeZone = "timeZone-value"
	}
}
# A UPN can also be used as -UserId.
Invoke-MgSnoozeUserEventReminder -UserId $userId -EventId $eventId -BodyParameter $params
```
