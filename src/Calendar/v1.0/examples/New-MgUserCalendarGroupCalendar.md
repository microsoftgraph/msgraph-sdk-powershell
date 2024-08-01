### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Calendar

$params = @{
	name = "Marketing calendar"
}

# A UPN can also be used as -UserId.
New-MgUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
This example shows how to use the New-MgUserCalendarGroupCalendar Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

