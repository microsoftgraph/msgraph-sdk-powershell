### Example 1: Using the Get-MgAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn -SignInId $signInId
```
This example shows how to use the Get-MgAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn
```
This example shows how to use the Get-MgAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn -Filter "startsWith(appDisplayName,'Azure')" -Top 10 
```
This example shows how to use the Get-MgAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgAuditLogSignIn Cmdlet
```powershell
Import-Module Microsoft.Graph.Reports
Get-MgAuditLogSignIn -Filter "(signInEventTypes/any(t: t ne 'interactiveUser'))" -Sort "createdDateTime DESC" -Top 10 
```
This example shows how to use the Get-MgAuditLogSignIn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
