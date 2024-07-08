### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Users

$params = @{
	displayName = "Travel items"
}

# A UPN can also be used as -UserId.
New-MgUserTodoList -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserTodoList Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

