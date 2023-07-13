### Example 1: Using the Set-MgBetaIdentityB2CUserFlowLanguageOverridePageContent Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Identity.SignIns
$params = @{
	LocalizedStrings = @(
	)
}
Set-MgBetaIdentityB2CUserFlowLanguageOverridePageContent -B2cIdentityUserFlowId $b2cIdentityUserFlowId -UserFlowLanguageConfigurationId $userFlowLanguageConfigurationId -UserFlowLanguagePageId $userFlowLanguagePageId -BodyParameter $params
```
This example shows how to use the Set-MgBetaIdentityB2CUserFlowLanguageOverridePageContent Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
