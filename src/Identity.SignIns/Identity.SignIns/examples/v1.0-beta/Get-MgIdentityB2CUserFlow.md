### Example 1: Using the Get-MgIdentityB2CUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlow -B2cIdentityUserFlowId $b2cIdentityUserFlowId
```
This example shows how to use the Get-MgIdentityB2CUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityB2CUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlow -ExpandProperty "identityProviders" 
```
This example shows how to use the Get-MgIdentityB2CUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityB2CUserFlow Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlow
```
This example shows how to use the Get-MgIdentityB2CUserFlow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
