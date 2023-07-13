### Example 1: Using the Get-MgUserOnenoteNotebookSectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId
```
This example shows how to use the Get-MgUserOnenoteNotebookSectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
