### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Users.Functions

# A UPN can also be used as -UserId.
Get-MgBetaUserOnenoteRecentNotebook -UserId $userId -IncludePersonalNotebooks $includePersonalNotebooksId 

```
This example shows how to use the Get-MgBetaUserOnenoteRecentNotebook Cmdlet.

