### Example 1: Using the Update-MgUserPassword Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	CurrentPassword = "xWwvJ]6NMw+bWH-d"
	NewPassword = "0eM85N54wFxWwvJ]"
}
# A UPN can also be used as -UserId.
Update-MgUserPassword -UserId $userId -BodyParameter $params
```
This example shows how to use the Update-MgUserPassword Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
