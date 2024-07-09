### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	password = "1234567890"
}

Test-MgBetaUserPassword -BodyParameter $params

```
This example shows how to use the Test-MgBetaUserPassword Cmdlet.

