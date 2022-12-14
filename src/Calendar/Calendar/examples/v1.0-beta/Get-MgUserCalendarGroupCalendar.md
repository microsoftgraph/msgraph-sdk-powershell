### Example 1: Using the Get-MgBetaUserCalendarGroupCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId
```
This example shows how to use the Get-MgBetaUserCalendarGroupCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
