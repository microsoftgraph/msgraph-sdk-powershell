### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.externalAuthenticationMethod"
	configurationId = "26310fee-860b-4eab-8749-ab730dcf335e"
	displayName = "Adatum"
}

New-MgBetaUserAuthenticationExternalAuthenticationMethod -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserAuthenticationExternalAuthenticationMethod Cmdlet.

