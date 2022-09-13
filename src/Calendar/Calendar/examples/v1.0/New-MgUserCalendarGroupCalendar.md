###Example 1
```
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "Marketing calendar"
}
# A UPN can also be used as -UserId.
New-MgUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId -BodyParameter $params
```
