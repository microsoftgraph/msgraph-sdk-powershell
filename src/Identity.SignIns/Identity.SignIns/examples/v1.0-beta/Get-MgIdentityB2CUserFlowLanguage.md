### Example 1: Using the Get-MgIdentityB2CUserFlowLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlowLanguage -B2cIdentityUserFlowId $b2cIdentityUserFlowId
```
This example shows how to use the Get-MgIdentityB2CUserFlowLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgIdentityB2CUserFlowLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlowLanguage -B2cIdentityUserFlowId $b2cIdentityUserFlowId -UserFlowLanguageConfigurationId $userFlowLanguageConfigurationId
```
This example shows how to use the Get-MgIdentityB2CUserFlowLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgIdentityB2CUserFlowLanguage Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2CUserFlowLanguage -B2cIdentityUserFlowId $b2cIdentityUserFlowId -Filter "isEnabled eq true" 
```
This example shows how to use the Get-MgIdentityB2CUserFlowLanguage Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
