### Example 1: Using the Remove-MgBetaUserCalendarGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Remove-MgBetaUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId
```
This example shows how to use the Remove-MgBetaUserCalendarGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
