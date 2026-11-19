### Example 1: Retrieve a specific webApplicationFirewallVerifications object.

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityRiskPreventionWebApplicationFirewallVerification -WebApplicationFirewallVerificationModelId $webApplicationFirewallVerificationModelId

```
This example will retrieve a specific webapplicationfirewallverifications object.

### Example 2: Retrieve a specific webApplicationFirewallVerifications object along with the details of their associated provider

```powershell

Import-Module Microsoft.Graph.Beta.Identity.SignIns

Get-MgBetaIdentityRiskPreventionWebApplicationFirewallVerification -WebApplicationFirewallVerificationModelId $webApplicationFirewallVerificationModelId -ExpandProperty "provider" 

```
This example will retrieve a specific webapplicationfirewallverifications object along with the details of their associated provider

