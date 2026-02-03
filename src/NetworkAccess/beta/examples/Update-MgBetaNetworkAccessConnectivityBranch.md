### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	name = "My updated branch"
}

Update-MgBetaNetworkAccessConnectivityBranch -BranchSiteId $branchSiteId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessConnectivityBranch Cmdlet.

