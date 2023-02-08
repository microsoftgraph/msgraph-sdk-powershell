### Example 1: Using the Get-MgUserOnenoteNotebookSection Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId
```
This example shows how to use the Get-MgUserOnenoteNotebookSection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
