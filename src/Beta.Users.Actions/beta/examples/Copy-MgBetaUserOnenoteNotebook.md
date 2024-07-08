### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	groupId = "groupId-value"
	renameAs = "renameAs-value"
}

# A UPN can also be used as -UserId.
Copy-MgBetaUserOnenoteNotebook -UserId $userId -NotebookId $notebookId -BodyParameter $params

```
This example shows how to use the Copy-MgBetaUserOnenoteNotebook Cmdlet.

