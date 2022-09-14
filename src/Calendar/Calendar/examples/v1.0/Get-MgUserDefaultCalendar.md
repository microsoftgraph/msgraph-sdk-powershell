### Example 1: Using the Get-MgUserDefaultCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
# A UPN can also be used as -UserId.
Get-MgUserDefaultCalendar -UserId $userId
```
This example shows how to use the Get-MgUserDefaultCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
