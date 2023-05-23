### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Calendar

$params = @{
	role = "write"
}

Update-MgUserCalendarPermission -UserId $userId -CalendarPermissionId $calendarPermissionId -BodyParameter $params
```
This example shows how to use the Remove-MgUserCalendarPermission Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

