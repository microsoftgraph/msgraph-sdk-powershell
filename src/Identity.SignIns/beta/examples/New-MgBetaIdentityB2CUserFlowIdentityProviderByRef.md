### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/identityProviders/{id}"
}

New-MgBetaIdentityB2CUserFlowIdentityProviderByRef -B2cIdentityUserFlowId $b2cIdentityUserFlowId -BodyParameter $params

```
This example shows how to use the New-MgBetaIdentityB2CUserFlowIdentityProviderByRef Cmdlet.

