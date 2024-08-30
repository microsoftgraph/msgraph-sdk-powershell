### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	name = "Backup Link"
}

Update-MgBetaNetworkAccessConnectivityBranchDeviceLink -BranchSiteId $branchSiteId -DeviceLinkId $deviceLinkId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessConnectivityBranchDeviceLink Cmdlet.

