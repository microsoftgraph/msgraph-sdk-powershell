### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	LocalizedStrings = @(
		@{
			ElementType = "UxElement"
			ElementId = $null
			StringId = "alert_message"
			Override = $true
			Value = "Are you sure that you want to cancel entering your information?"
		}
	)
}

Set-MgIdentityB2XUserFlowLanguageOverridePageContent -B2xIdentityUserFlowId $b2xIdentityUserFlowId -UserFlowLanguageConfigurationId $userFlowLanguageConfigurationId -UserFlowLanguagePageId $userFlowLanguagePageId -BodyParameter $params

```
This example shows how to use the Set-MgIdentityB2XUserFlowLanguageOverridePageContent Cmdlet.

