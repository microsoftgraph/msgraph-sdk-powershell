### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Identity.SignIns

$params = @{
	definition = @(
		'{"TokenLifetimePolicy":{"Version":1,"AccessTokenLifetime":"5:30:00"}}'
	)
	displayName = "Contoso token lifetime policy"
	isOrganizationDefault = $true
}

Update-MgPolicyTokenLifetimePolicy -TokenLifetimePolicyId $tokenLifetimePolicyId -BodyParameter $params
```
This example shows how to use the Update-MgPolicyTokenLifetimePolicy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

