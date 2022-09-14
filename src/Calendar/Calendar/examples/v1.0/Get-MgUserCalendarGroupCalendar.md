### Example 1: Using the Get-MgUserCalendarGroupCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId
```
This example shows how to use the Get-MgUserCalendarGroupCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
