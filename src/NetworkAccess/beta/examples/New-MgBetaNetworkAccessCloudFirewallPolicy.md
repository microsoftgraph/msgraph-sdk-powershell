### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.cloudFirewallPolicy"
	name = "Block unauthorized egress"
	description = "Policy to block unauthorized outbound connections"
	settings = @{
		defaultAction = "allow"
	}
}

New-MgBetaNetworkAccessCloudFirewallPolicy -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessCloudFirewallPolicy Cmdlet.

