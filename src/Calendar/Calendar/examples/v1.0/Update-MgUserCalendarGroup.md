### Example 1
``` powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "name-value"
}
# A UPN can also be used as -UserId.
Update-MgUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
