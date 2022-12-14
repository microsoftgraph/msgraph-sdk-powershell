### Example 1: Using the Get-MgBetaUserCalendarGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserCalendarGroup -UserId $userId -CalendarGroupId $calendarGroupId
```
This example shows how to use the Get-MgBetaUserCalendarGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserCalendarGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserCalendarGroup -UserId $userId
```
This example shows how to use the Get-MgBetaUserCalendarGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
