### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users

$params = @{
	displayName = "Vacation Plan"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserTodoList -UserId $userId -TodoTaskListId $todoTaskListId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserTodoList Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

