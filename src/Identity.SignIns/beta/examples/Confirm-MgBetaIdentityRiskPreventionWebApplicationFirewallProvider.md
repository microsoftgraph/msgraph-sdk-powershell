### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

$params = @{
	hostName = "www.contoso.com"
}

Confirm-MgBetaIdentityRiskPreventionWebApplicationFirewallProvider -WebApplicationFirewallProviderId $webApplicationFirewallProviderId -BodyParameter $params

```
This example shows how to use the Confirm-MgBetaIdentityRiskPreventionWebApplicationFirewallProvider Cmdlet.

