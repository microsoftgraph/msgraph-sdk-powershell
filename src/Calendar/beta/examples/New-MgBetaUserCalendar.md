### Example 1: Using the New-MgBetaUserCalendar Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	Name = "Volunteer"
}
# A UPN can also be used as -UserId.
New-MgBetaUserCalendar -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendar Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
