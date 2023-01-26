### Example 1: Using the Remove-MgUserCalendarPermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
Remove-MgUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId
```
This example shows how to use the Remove-MgUserCalendarPermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
