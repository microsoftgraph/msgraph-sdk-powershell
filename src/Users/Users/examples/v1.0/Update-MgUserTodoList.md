### Example 1
``` powershell
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "Vacation Plan"
}
# A UPN can also be used as -UserId.
Update-MgUserTodoList -UserId $userId -TodoTaskListId $todoTaskListId -BodyParameter $params
```
