### Example 1: Using the Update-MgBetaUserCalendarPermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	Role = "write"
}
Update-MgBetaUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserCalendarPermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
