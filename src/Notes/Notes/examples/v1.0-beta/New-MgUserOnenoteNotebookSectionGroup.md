### Example 1: Using the New-MgBetaUserOnenoteNotebookSectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
$params = @{
	DisplayName = "Section group name"
}
# A UPN can also be used as -UserId.
New-MgBetaUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserOnenoteNotebookSectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
