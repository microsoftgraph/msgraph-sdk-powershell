### Example 1
``` powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserDefaultCalendar -UserId $userId
```
