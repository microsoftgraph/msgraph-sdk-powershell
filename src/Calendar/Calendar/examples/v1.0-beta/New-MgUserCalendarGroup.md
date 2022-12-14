### Example 1: Using the New-MgBetaUserCalendarGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Calendar
$params = @{
	Name = "Personal events"
}
# A UPN can also be used as -UserId.
New-MgBetaUserCalendarGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserCalendarGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
