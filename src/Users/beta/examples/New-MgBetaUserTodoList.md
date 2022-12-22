### Example 1: Using the New-MgBetaUserTodoList Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	DisplayName = "Travel items"
}
# A UPN can also be used as -UserId.
New-MgBetaUserTodoList -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
