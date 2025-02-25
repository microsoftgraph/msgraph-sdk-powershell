### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Notes

# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteNotebookRecentNotebook -UserId $userId -IncludePersonalNotebooks $includePersonalNotebooksId 

```
This example shows how to use the Get-MgBetaUserOnenoteNotebookRecentNotebook Cmdlet.

