### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

# A UPN can also be used as -UserId.
Invoke-MgBetaDismissUserEventReminder -UserId $userId -EventId $eventId
```
This example shows how to use the Invoke-MgBetaDismissUserEventInstanceReminder Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

