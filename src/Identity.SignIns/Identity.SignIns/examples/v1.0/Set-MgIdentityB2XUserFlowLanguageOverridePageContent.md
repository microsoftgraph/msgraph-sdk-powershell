### Example 1
``` powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	LocalizedStrings = @(
	)
}
Set-MgIdentityB2XUserFlowLanguageOverridePageContent -B2xIdentityUserFlowId $b2xIdentityUserFlowId -UserFlowLanguageConfigurationId $userFlowLanguageConfigurationId -UserFlowLanguagePageId $userFlowLanguagePageId -BodyParameter $params
```
