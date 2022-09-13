###Example 1
```
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn -SignInId $signInId
```
###Example 2
```
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn -Filter "startsWith(appDisplayName,'Graph')" -Top 10 
```
###Example 3
```
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn
```
