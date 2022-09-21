### Example 1: Using the New-MgUserTodoListTaskAttachment Cmdlet
```powershell
Import-Module Microsoft.Graph.Users
$params = @{
	"@odata.type" = "#microsoft.graph.taskFileAttachment"
	Name = "smile"
	ContentBytes = "a0b1c76de9f7="
	ContentType = "image/gif"
}
# A UPN can also be used as -UserId.
New-MgUserTodoListTaskAttachment -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgUserTodoListTaskAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
