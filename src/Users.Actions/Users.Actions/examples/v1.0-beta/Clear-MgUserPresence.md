### Example 1: Using the Clear-MgBetaUserPresence Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	SessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87"
}
Clear-MgBetaUserPresence -UserId $userId -BodyParameter $params
```
This example shows how to use the Clear-MgBetaUserPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
