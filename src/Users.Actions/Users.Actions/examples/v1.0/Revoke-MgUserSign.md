### Example 1
```powershell
Import-Module Microsoft.Graph.Users.Actions
# A UPN can also be used as -UserId.
Revoke-MgUserSign -UserId $userId
```
