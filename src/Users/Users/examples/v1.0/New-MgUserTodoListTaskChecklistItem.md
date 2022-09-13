###Example 1
```
Import-Module Microsoft.Graph.Users
$params = @{
	DisplayName = "Final sign-off from the team"
}
# A UPN can also be used as -UserId.
New-MgUserTodoListTaskChecklistItem -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
