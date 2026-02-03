### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	name = "device link 1"
	ipAddress = "24.123.22.168"
	deviceVendor = "intel"
	bandwidthCapacityInMbps = "mbps250"
	bgpConfiguration = @{
		localIpAddress = "1.128.24.22"
		peerIpAddress = "1.128.24.28"
		asn = 4
	}
	redundancyConfiguration = @{
		zoneLocalIpAddress = "1.128.23.20"
		redundancyTier = "zoneRedundancy"
	}
	tunnelConfiguration = @{
		"@odata.type" = "microsoft.graph.networkAccess.tunnelConfigurationIKEv2Default"
		preSharedKey = "/microsoft/keyVault/placeholder"
	}
}

New-MgBetaNetworkAccessConnectivityBranchDeviceLink -BranchSiteId $branchSiteId -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessConnectivityBranchDeviceLink Cmdlet.

