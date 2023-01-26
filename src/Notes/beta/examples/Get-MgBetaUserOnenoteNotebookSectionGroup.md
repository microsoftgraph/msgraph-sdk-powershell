### Example 1: Using the Get-MgBetaUserOnenoteNotebookSectionGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Notes
# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId
```
This example shows how to use the Get-MgBetaUserOnenoteNotebookSectionGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
