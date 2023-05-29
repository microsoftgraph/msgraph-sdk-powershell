### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Users

$params = @{
	displayName = "Travel items"
}

# A UPN can also be used as -UserId.
New-MgBetaUserTodoList -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

