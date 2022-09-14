### Example 1: Using the Get-MgUserDrive Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
# A UPN can also be used as -UserId.
Get-MgUserDrive -UserId $userId
```
This example shows how to use the Get-MgUserDrive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserDrive Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
Get-MgUserDrive -UserId $userId
```
This example shows how to use the Get-MgUserDrive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
