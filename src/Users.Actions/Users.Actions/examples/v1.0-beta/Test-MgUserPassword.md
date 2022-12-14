### Example 1: Using the Test-MgBetaUserPassword Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Password = "1234567890"
}
Test-MgBetaUserPassword -BodyParameter $params
```
This example shows how to use the Test-MgBetaUserPassword Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
