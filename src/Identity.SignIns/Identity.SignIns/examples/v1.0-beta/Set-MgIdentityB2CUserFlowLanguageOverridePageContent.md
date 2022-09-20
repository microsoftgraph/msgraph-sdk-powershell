### Example 1: Using the Set-MgIdentityB2CUserFlowLanguageOverridePageContent Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	LocalizedStrings = @(
	)
}
Set-MgIdentityB2CUserFlowLanguageOverridePageContent -B2cIdentityUserFlowId $b2cIdentityUserFlowId -UserFlowLanguageConfigurationId $userFlowLanguageConfigurationId -UserFlowLanguagePageId $userFlowLanguagePageId -BodyParameter $params
```
This example shows how to use the Set-MgIdentityB2CUserFlowLanguageOverridePageContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
