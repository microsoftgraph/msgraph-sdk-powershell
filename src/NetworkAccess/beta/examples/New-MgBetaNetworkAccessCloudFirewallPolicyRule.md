### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	"@odata.type" = "#microsoft.graph.networkaccess.cloudFirewallRule"
	name = "Block outbound to risky destinations"
	description = "Block traffic to specific IPs on common ports"
	priority = 
	action = "block"
	settings = @{
		status = "enabled"
	}
	matchingConditions = @{
		sources = @{
			addresses = @(
				@{
					"@odata.type" = "#microsoft.graph.networkaccess.cloudFirewallSourceIpAddress"
					values = @(
					"192.168.1.1"
				"192.168.0.0/16"
			"172.16.0.0-172.16.255.255"
		)
	}
)
ports = @(
"80"
"443"
"445-447"
)
}
destinations = @{
addresses = @(
@{
"@odata.type" = "#microsoft.graph.networkaccess.cloudFirewallDestinationIpAddress"
values = @(
"10.0.0.1"
)
}
)
ports = @(
"80"
"443"
"445-447"
)
protocols = "tcp"
}
}
}

New-MgBetaNetworkAccessCloudFirewallPolicyRule -CloudFirewallPolicyId $cloudFirewallPolicyId -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessCloudFirewallPolicyRule Cmdlet.

