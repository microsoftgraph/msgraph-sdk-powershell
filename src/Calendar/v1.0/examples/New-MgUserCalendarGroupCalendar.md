### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Calendar

# A UPN can also be used as -UserId.
Get-MgUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId
```
This example shows how to use the New-MgUserCalendarGroupCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

