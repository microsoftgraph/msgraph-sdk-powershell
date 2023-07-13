### Example 1: Using the Invoke-MgBetaDismissUserEventReminder Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
# A UPN can also be used as -UserId.
Invoke-MgBetaDismissUserEventReminder -UserId $userId -EventId $eventId
```
This example shows how to use the Invoke-MgBetaDismissUserEventReminder Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
