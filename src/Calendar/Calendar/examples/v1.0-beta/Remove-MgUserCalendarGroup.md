### Example 1: Using the Remove-MgUserCalendarGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Remove-MgUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId
```
This example shows how to use the Remove-MgUserCalendarGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
