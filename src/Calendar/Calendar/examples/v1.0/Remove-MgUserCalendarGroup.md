###Example 1
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Remove-MgUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId
```
