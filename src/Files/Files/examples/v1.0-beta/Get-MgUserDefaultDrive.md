### Example 1: Using the Get-MgBetaUserDefaultDrive Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Files
Get-MgBetaUserDefaultDrive -UserId $userId
```
This example shows how to use the Get-MgBetaUserDefaultDrive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaUserDefaultDrive Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Files
# A UPN can also be used as -UserId.
Get-MgBetaUserDefaultDrive -UserId $userId
```
This example shows how to use the Get-MgBetaUserDefaultDrive Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
