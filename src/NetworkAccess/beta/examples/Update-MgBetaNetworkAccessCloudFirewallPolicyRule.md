### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	description = "Updated rule description"
	priority = 
}

Update-MgBetaNetworkAccessCloudFirewallPolicyRule -CloudFirewallPolicyId $cloudFirewallPolicyId -PolicyRuleId $policyRuleId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessCloudFirewallPolicyRule Cmdlet.

