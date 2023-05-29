### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Users

$params = @{
	"@odata.type" = "#microsoft.graph.taskFileAttachment"
	name = "smile"
	contentBytes = "a0b1c76de9f7="
	contentType = "image/gif"
}

# A UPN can also be used as -UserId.
New-MgBetaUserTodoListTaskAttachment -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoListTaskAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

