### Example 1
```powershell
Import-Module Microsoft.Graph.CloudCommunications
Get-MgUserPresence -UserId $userId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.CloudCommunications
# A UPN can also be used as -UserId.
Get-MgUserPresence -UserId $userId
```
