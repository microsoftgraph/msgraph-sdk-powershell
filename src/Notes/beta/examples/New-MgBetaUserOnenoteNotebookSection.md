### Example 1: Using the New-MgBetaUserOnenoteNotebookSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
$params = @{
	DisplayName = "Section name"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOnenoteNotebookSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
