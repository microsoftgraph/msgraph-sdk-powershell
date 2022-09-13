###Example 1
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserCalendarGroupCalendar -UserId $userId -CalendarGroupId $calendarGroupId
```
