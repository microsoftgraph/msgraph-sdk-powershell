### Example 1: Using the Remove-MgUserEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Remove-MgUserEvent -UserId $userId -EventId $eventId
```
This example shows how to use the Remove-MgUserEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
