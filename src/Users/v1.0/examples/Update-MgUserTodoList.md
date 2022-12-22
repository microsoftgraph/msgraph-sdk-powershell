### Example 1: Using the Update-MgUserTodoList Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "Vacation Plan"
}
# A UPN can also be used as -UserId.
Update-MgUserTodoList -UserId $userId -TodoTaskListId $todoTaskListId -BodyParameter $params
```
This example shows how to use the Update-MgUserTodoList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
