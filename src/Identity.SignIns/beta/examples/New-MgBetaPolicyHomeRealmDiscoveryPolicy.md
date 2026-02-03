### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	definition = @(
	'{"HomeRealmDiscoveryPolicy":{"AccelerateToFederatedDomain":true,"PreferredDomain":"federated.example.edu","AlternateIdLogin":{"Enabled":true}}}'
)
displayName = "displayName-value"
isOrganizationDefault = $true
}

New-MgBetaPolicyHomeRealmDiscoveryPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaPolicyHomeRealmDiscoveryPolicy Cmdlet.

