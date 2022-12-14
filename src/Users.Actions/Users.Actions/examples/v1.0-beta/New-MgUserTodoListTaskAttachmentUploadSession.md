### Example 1: Using the New-MgBetaUserTodoListTaskAttachmentUploadSession Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	AttachmentInfo = @{
		AttachmentType = "file"
		Name = "flower"
		Size = 3483322
	}
}
# A UPN can also be used as -UserId.
New-MgBetaUserTodoListTaskAttachmentUploadSession -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserTodoListTaskAttachmentUploadSession Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
