### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgUserAuthenticationOperation -UserId $userId -LongRunningOperationId $longRunningOperationId
```
