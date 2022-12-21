### Example 1: Using the New-MgBetaUserTodoListTaskAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users
$params = @{
	"@odata.type" = "#microsoft.graph.taskFileAttachment"
	Name = "smile"
	ContentBytes = "a0b1c76de9f7="
	ContentType = "image/gif"
}
# A UPN can also be used as -UserId.
New-MgBetaUserTodoListTaskAttachment -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoListTaskAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
