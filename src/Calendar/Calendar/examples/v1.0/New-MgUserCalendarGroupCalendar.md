### Example 1: Using the New-MgUserCalendarGroupCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "Marketing calendar"
}
# A UPN can also be used as -UserId.
New-MgUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
This example shows how to use the New-MgUserCalendarGroupCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
