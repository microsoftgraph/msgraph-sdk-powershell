### Example 1: Using the Get-MgUserDefaultDrive Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
Get-MgUserDefaultDrive -UserId $userId
```
This example shows how to use the Get-MgUserDefaultDrive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgUserDefaultDrive Cmdlet
```powershell
Import-Module Microsoft.Graph.Files
# A UPN can also be used as -UserId.
Get-MgUserDefaultDrive -UserId $userId
```
This example shows how to use the Get-MgUserDefaultDrive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
