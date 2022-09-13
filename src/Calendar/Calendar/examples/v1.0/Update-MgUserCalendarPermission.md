###Example 1
```
Import-Module Microsoft.Graph.Calendar
$params = @{
	Role = "write"
}
Update-MgUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId -BodyParameter $params
```
