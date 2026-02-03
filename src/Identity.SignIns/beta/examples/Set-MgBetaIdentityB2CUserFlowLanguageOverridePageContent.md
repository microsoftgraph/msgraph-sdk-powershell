### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	LocalizedStrings = @(
		@{
			ElementType = "UxElement"
			ElementId = $null
			StringId = "alert_message"
			Override = $true
			Value = "Are you sure that you want to cancel your selection?"
		}
	)
}

Set-MgBetaIdentityB2CUserFlowLanguageOverridePageContent -B2cIdentityUserFlowId $b2cIdentityUserFlowId -UserFlowLanguageConfigurationId $userFlowLanguageConfigurationId -UserFlowLanguagePageId $userFlowLanguagePageId -BodyParameter $params

```
This example shows how to use the Set-MgBetaIdentityB2CUserFlowLanguageOverridePageContent Cmdlet.

