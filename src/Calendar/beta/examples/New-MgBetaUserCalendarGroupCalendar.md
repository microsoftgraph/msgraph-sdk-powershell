### Example 1: Using the New-MgBetaUserCalendarGroupCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	Name = "Marketing calendar"
}
# A UPN can also be used as -UserId.
New-MgBetaUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendarGroupCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
