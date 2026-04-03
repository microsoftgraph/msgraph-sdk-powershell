### Example 1: Create a new AkamaiWebApplicationFirewallProvider object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.akamaiWebApplicationFirewallProvider"
	displayName = "Akamai Provider Example"
	hostPrefix = "akab-exampleprefix"
	clientSecret = "akamai_example_secret_123"
	clientToken = "akamai_example_token_456"
	accessToken = "akamai_example_token_789"
}

New-MgIdentityRiskPreventionWebApplicationFirewallProvider -BodyParameter $params

```
This example will create a new akamaiwebapplicationfirewallprovider object

### Example 2: Create a new cloudFlareWebApplicationFirewallProvider object

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.cloudFlareWebApplicationFirewallProvider"
	displayName = "Cloudflare Provider Example"
	zoneId = "11111111111111111111111111111111"
	apiToken = "cf_example_token_123"
}

New-MgIdentityRiskPreventionWebApplicationFirewallProvider -BodyParameter $params

```
This example will create a new cloudflarewebapplicationfirewallprovider object

