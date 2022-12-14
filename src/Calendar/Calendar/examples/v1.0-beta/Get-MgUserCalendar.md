### Example 1: Using the Get-MgBetaUserCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
# A UPN can also be used as -UserId.
Get-MgBetaUserCalendar -UserId $userId
```
This example shows how to use the Get-MgBetaUserCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
