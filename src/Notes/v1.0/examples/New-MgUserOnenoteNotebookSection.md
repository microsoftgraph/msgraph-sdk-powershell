### Example 1: Using the New-MgUserOnenoteNotebookSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "Section name"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the New-MgUserOnenoteNotebookSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
