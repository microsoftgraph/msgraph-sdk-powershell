### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Calendar

$params = @{
	role = "write"
}

Update-MgBetaUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserCalendarPermission Cmdlet.

