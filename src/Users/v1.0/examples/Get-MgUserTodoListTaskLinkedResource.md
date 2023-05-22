### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Users

$params = @{
	"@odata.type" = "#microsoft.graph.linkedResource"
	webUrl = "http://microsoft.com"
	applicationName = "Microsoft"
	displayName = "Microsoft"
}

# A UPN can also be used as -UserId.
Update-MgUserTodoListTaskLinkedResource -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -LinkedResourceId $linkedResourceId -BodyParameter $params
```
This example shows how to use the Get-MgUserTodoListTaskLinkedResource Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

