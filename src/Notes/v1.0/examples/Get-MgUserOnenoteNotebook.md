### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Notes

# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebook -UserId $userId -NotebookId $notebookId
```
This example shows how to use the Get-MgUserOnenoteNotebook Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

