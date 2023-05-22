### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Users

# A UPN can also be used as -UserId.
Remove-MgBetaUserTodoListTaskAttachment -UserId $userId -TodoTaskListId $todoTaskListId -TodoTaskId $todoTaskId -AttachmentBaseId $attachmentBaseId
```
This example shows how to use the Remove-MgBetaBetaUserTodoListTaskAttachment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

