### Example 1
```powershell
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn -SignInId $signInId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn -Filter "startsWith(appDisplayName,'Graph')" -Top 10 
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn
```
