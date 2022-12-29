### Example 1: Using the Clear-MgUserPresence Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	SessionId = "22553876-f5ab-4529-bffb-cfe50aa89f87"
}
Clear-MgUserPresence -UserId $userId -BodyParameter $params
```
This example shows how to use the Clear-MgUserPresence Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
