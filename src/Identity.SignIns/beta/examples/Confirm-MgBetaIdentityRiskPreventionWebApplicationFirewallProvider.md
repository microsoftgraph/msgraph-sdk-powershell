### Example 1: Verify a specific webApplicationFirewallProvider object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	hostName = "www.contoso.com"
}

Confirm-MgBetaIdentityRiskPreventionWebApplicationFirewallProvider -WebApplicationFirewallProviderId $webApplicationFirewallProviderId -BodyParameter $params

```
This example will verify a specific webapplicationfirewallprovider object

### Example 2: Verify a specific webApplicationFirewallProviders object along with the details of their associated provider.

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	hostName = "www.contoso.com"
}

Confirm-MgBetaIdentityRiskPreventionWebApplicationFirewallProvider -WebApplicationFirewallProviderId $webApplicationFirewallProviderId -ExpandProperty "provider"  -BodyParameter $params

```
This example will verify a specific webapplicationfirewallproviders object along with the details of their associated provider.

