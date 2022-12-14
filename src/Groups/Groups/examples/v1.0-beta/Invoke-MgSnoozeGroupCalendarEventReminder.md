### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	NewReminderTime = @{
		DateTime = "dateTime-value"
		TimeZone = "timeZone-value"
	}
}

# A UPN can also be used as -UserId.
Invoke-MgBetaSnoozeUserEventReminder -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaSnoozeGroupCalendarEventReminder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

