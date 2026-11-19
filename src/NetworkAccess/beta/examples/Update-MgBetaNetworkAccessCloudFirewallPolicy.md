### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	description = "Updated policy description"
}

Update-MgBetaNetworkAccessCloudFirewallPolicy -CloudFirewallPolicyId $cloudFirewallPolicyId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessCloudFirewallPolicy Cmdlet.

