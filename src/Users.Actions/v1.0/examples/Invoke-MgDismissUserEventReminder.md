### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Actions

# A UPN can also be used as -UserId.
Invoke-MgDismissUserEventReminder -UserId $userId -EventId $eventId

```
This example shows how to use the Invoke-MgDismissUserEventReminder Cmdlet.

