### Example 1: Using the Update-MgUserCalendarPermission Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Role = "write"
}
Update-MgUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId -BodyParameter $params
```
This example shows how to use the Update-MgUserCalendarPermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
