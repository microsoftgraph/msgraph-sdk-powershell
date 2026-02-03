### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	isLanguageCustomizationEnabled = $true
	defaultLanguageTag = "en"
}

Update-MgBetaIdentityB2CUserFlow -B2cIdentityUserFlowId $b2cIdentityUserFlowId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityB2CUserFlow Cmdlet.

