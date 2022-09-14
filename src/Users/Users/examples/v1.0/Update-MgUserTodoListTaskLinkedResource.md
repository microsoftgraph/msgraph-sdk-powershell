### Example 1: Using the Update-MgUserTodoListTaskLinkedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	"@odata.type" = "#microsoft.graph.linkedResource"
	WebUrl = "http://microsoft.com"
	ApplicationName = "Microsoft"
	DisplayName = "Microsoft"
}
# A UPN can also be used as -UserId.
Update-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -LinkedResourceId $linkedResourceId -BodyParameter $params
```
This example shows how to use the Update-MgUserTodoListTaskLinkedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
