### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	definition = @(
	'{"TokenLifetimePolicy":{"Version":1,"AccessTokenLifetime":"8:00:00"}}'
)
displayName = "Contoso token lifetime policy"
isOrganizationDefault = $true
}

New-MgBetaPolicyTokenLifetimePolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaPolicyTokenLifetimePolicy Cmdlet.

