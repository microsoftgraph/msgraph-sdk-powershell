### Example 1: Using the Test-MgUserPassword Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	Password = "1234567890"
}
Test-MgUserPassword -BodyParameter $params
```
This example shows how to use the Test-MgUserPassword Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
