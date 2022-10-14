### Example 1: Using the New-MgIdentityB2CUserFlowIdentityProviderByRef Cmdlet
```powershell
Import-Module Microsoft.Graph.Identity.SignIns
$params = @{
	"@odata.id" = "https://graph.microsoft.com/beta/identityProviders/{id}"
}
New-MgIdentityB2CUserFlowIdentityProviderByRef -B2cIdentityUserFlowId $b2cIdentityUserFlowId -BodyParameter $params
```
This example shows how to use the New-MgIdentityB2CUserFlowIdentityProviderByRef Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
