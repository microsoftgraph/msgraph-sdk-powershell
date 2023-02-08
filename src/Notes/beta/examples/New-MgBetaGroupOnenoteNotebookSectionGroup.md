### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Notes

# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId
```
This example shows how to use the New-MgBetaGroupOnenoteNotebookSectionGroup Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

