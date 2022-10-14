### Example 1: Using the Get-MgIdentityB2XUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
This example shows how to use the Get-MgIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityB2XUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow -ExpandProperty "identityProviders" 
```
This example shows how to use the Get-MgIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityB2XUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlow
```
This example shows how to use the Get-MgIdentityB2XUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
