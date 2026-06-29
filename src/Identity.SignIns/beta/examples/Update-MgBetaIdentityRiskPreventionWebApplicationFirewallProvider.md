### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	"@odata.type" = "#microsoft.graph.cloudFlareWebApplicationFirewallProvider"
	displayName = "cloudFlare"
}

Update-MgBetaIdentityRiskPreventionWebApplicationFirewallProvider -WebApplicationFirewallProviderId $webApplicationFirewallProviderId -BodyParameter $params

```
This example shows how to use the Update-MgBetaIdentityRiskPreventionWebApplicationFirewallProvider Cmdlet.

