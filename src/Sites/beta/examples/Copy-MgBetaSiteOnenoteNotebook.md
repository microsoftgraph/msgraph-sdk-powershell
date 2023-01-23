### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	GroupId = "groupId-value"
	RenameAs = "renameAs-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserOnenoteNotebook -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the Copy-MgBetaSiteOnenoteNotebook Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

