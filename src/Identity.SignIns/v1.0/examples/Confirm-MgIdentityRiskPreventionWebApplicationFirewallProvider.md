### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.SignIns

$params = @{
	hostName = "www.contoso.com"
}

Confirm-MgIdentityRiskPreventionWebApplicationFirewallProvider -WebApplicationFirewallProviderId $webApplicationFirewallProviderId -BodyParameter $params

```
This example shows how to use the Confirm-MgIdentityRiskPreventionWebApplicationFirewallProvider Cmdlet.

