### Example 1
```powershell
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookSectionGroup -UserId $userId -NotebookId $notebookId
```
