### Example 1: Using the New-MgUserCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Calendar
$params = @{
	Name = "Volunteer"
}
# A UPN can also be used as -UserId.
New-MgUserCalendar -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
