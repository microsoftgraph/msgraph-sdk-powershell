### Example 1: Using the Invoke-MgBetaSnoozeUserEventReminder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	NewReminderTime = @{
		DateTime = "2016-10-19T10:37:00Z"
		TimeZone = "timeZone-value"
	}
}
# A UPN can also be used as -UserId.
Invoke-MgBetaSnoozeUserEventReminder -UserId $userId -EventId $eventId -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaSnoozeUserEventReminder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
