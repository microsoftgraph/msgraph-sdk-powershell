### Example 1: Using the Copy-MgUserOnenoteNotebook Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	GroupId = "groupId-value"
	RenameAs = "renameAs-value"
}
# A UPN can also be used as -UserId.
Copy-MgUserOnenoteNotebook -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the Copy-MgUserOnenoteNotebook Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
