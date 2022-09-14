### Example 1
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowLanguage -B2xIdentityUserFlowId $b2xIdentityUserFlowId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
Get-MgIdentityB2XUserFlowLanguage -B2xIdentityUserFlowId $b2xIdentityUserFlowId -UserFlowLanguageConfigurationId $userFlowLanguageConfigurationId
```
