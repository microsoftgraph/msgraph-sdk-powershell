### Example 1: Using the Update-MgUserCalendarGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "name-value"
}
# A UPN can also be used as -UserId.
Update-MgUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
This example shows how to use the Update-MgUserCalendarGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
