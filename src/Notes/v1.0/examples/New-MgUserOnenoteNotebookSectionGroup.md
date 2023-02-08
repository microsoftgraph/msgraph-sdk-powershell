### Example 1: Using the New-MgUserOnenoteNotebookSectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
$params = @{
	DisplayName = "Section group name"
}
# A UPN can also be used as -UserId.
New-MgUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the New-MgUserOnenoteNotebookSectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
