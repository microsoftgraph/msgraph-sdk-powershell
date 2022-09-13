###Example 1
```
Import-Module Microsoft.Graph.Notes
# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookSection -UserId $userId -NotebookId $notebookId
```
