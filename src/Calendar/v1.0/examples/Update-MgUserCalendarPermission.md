### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Calendar

$params = @{
	role = "write"
}

Update-MgUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId -BodyParameter $params

```
This example shows how to use the Update-MgUserCalendarPermission Cmdlet.

