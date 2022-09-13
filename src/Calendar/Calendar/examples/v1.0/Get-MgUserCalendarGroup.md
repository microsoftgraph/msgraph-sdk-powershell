###Example 1
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId
```
###Example 2
```
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserCalendarGroup -UserId $userId
```
