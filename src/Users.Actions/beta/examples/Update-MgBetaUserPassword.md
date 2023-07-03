### Example 1: Using the Update-MgBetaUserPassword Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	CurrentPassword = "xWwvJ]6NMw+bWH-d"
	NewPassword = "0eM85N54wFxWwvJ]"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserPassword -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserPassword Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
