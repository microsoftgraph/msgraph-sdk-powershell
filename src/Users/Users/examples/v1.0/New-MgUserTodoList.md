### Example 1: Using the New-MgUserTodoList Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "Travel items"
}
# A UPN can also be used as -UserId.
New-MgUserTodoList -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
