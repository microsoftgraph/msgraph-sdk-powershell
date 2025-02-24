### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users

$params = @{
	attachmentInfo = @{
		attachmentType = "file"
		name = "flower"
		size = 3483322
	}
}

# A UPN can also be used as -UserId.
New-MgUserTodoListTaskAttachmentUploadSession -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -BodyParameter $params

```
This example shows how to use the New-MgUserTodoListTaskAttachmentUploadSession Cmdlet.

