### Example 1: Using the Get-MgUserCalendarView Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserCalendarView -UserId $userId -Startdatetime "2017-01-01T19:00:00-08:00" -Enddatetime "2017-01-07T19:00:00-08:00" 
```
This example shows how to use the Get-MgUserCalendarView Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
