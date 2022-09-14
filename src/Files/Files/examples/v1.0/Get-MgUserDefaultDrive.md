### Example 1
```powershell
Import-Module Microsoft.Graph.Files
Get-MgUserDefaultDrive -UserId $userId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Files
# A UPN can also be used as -UserId.
Get-MgUserDefaultDrive -UserId $userId
```
