### Example 1: Using the New-MgUserCalendarGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "Personal events"
}
# A UPN can also be used as -UserId.
New-MgUserCalendarGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserCalendarGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
