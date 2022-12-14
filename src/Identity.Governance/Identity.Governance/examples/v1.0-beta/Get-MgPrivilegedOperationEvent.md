### Example 1: Using the Get-MgBetaPrivilegedOperationEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedOperationEvent -Filter "requestType eq 'Assign'" 
```
This example shows how to use the Get-MgBetaPrivilegedOperationEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaPrivilegedOperationEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedOperationEvent -Filter "requestType eq 'Activate'" 
```
This example shows how to use the Get-MgBetaPrivilegedOperationEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgBetaPrivilegedOperationEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedOperationEvent -Filter "requestType eq 'Deactivate'" 
```
This example shows how to use the Get-MgBetaPrivilegedOperationEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgBetaPrivilegedOperationEvent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.Governance
Get-MgBetaPrivilegedOperationEvent -Filter "(creationDateTime ge 2017-06-25T07:00:00Z) and (creationDateTime le 2017-07-25T17:30:17Z)" -CountVariable CountVar -Sort "creationDateTime desc" 
```
This example shows how to use the Get-MgBetaPrivilegedOperationEvent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
