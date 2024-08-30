### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	name = "test branch - 11:50"
	country = "United States"
	region = "East US"
	bandwidthCapacity = 500
}

New-MgBetaNetworkAccessConnectivityBranch -BodyParameter $params

```
This example shows how to use the New-MgBetaNetworkAccessConnectivityBranch Cmdlet.

