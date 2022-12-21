### Example 1: Using the Update-MgBetaUserTodoListTaskLinkedResource Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	"@odata.type" = "#microsoft.graph.linkedResource"
	WebUrl = "http://microsoft.com"
	ApplicationName = "Microsoft"
	DisplayName = "Microsoft"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -LinkedResourceId $linkedResourceId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserTodoListTaskLinkedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
