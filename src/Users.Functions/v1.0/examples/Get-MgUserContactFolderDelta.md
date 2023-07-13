### Example 1: Using the Get-MgUserContactFolderDelta Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Functions
# A UPN can also be used as -UserId.
Get-MgUserContactFolderDelta -UserId $userId
```
This example shows how to use the Get-MgUserContactFolderDelta Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
