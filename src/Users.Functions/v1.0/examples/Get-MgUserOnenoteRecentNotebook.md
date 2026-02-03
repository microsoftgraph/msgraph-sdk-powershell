### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Users.Functions

# A UPN can also be used as -UserId.
Get-MgUserOnenoteRecentNotebook -UserId $userId -IncludePersonalNotebooks $includePersonalNotebooksId 

```
This example shows how to use the Get-MgUserOnenoteRecentNotebook Cmdlet.

