### Example 1: Using the New-MgUserTodoListTaskAttachmentUploadSession Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	AttachmentInfo = @{
		AttachmentType = "file"
		Name = "flower"
		Size = 3483322
	}
}
# A UPN can also be used as -UserId.
New-MgUserTodoListTaskAttachmentUploadSession -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgUserTodoListTaskAttachmentUploadSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
