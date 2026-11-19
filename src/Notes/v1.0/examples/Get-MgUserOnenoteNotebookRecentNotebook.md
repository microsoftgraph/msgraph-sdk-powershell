### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Notes

# A UPN can also be used as -UserId.
Get-MgUserOnenoteNotebookRecentNotebook -UserId $userId -IncludePersonalNotebooks $includePersonalNotebooksId 

```
This example shows how to use the Get-MgUserOnenoteNotebookRecentNotebook Cmdlet.

