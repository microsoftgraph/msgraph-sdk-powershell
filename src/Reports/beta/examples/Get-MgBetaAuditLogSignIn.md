### Example 1: Using the Get-MgBetaAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Reports
Get-MgBetaAuditLogSignIn -SignInId $signInId
```
This example shows how to use the Get-MgBetaAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Reports
Get-MgBetaAuditLogSignIn
```
This example shows how to use the Get-MgBetaAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Reports
Get-MgBetaAuditLogSignIn -Filter "startsWith(appDisplayName,'Azure')" -Top 10 
```
This example shows how to use the Get-MgBetaAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Reports
Get-MgBetaAuditLogSignIn -Filter "(signInEventTypes/any(t: t ne 'interactiveUser'))" -Sort "createdDateTime DESC" -Top 10 
```
This example shows how to use the Get-MgBetaAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
