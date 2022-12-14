### Example 1: Using the Get-MgBetaUserDefaultCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserDefaultCalendar -UserId $userId
```
This example shows how to use the Get-MgBetaUserDefaultCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
