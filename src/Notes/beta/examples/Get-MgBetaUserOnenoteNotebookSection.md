### Example 1: Using the Get-MgBetaUserOnenoteNotebookSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId
```
This example shows how to use the Get-MgBetaUserOnenoteNotebookSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
