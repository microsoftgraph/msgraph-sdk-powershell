### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.NetworkAccess

$params = @{
	associations = @(
		@{
			"@odata.type" = "#microsoft.graph.networkaccess.associatedBranch"
			branchId = "88e5a488-92c3-45d6-ba56-e5cfa63677e8"
		}
	)
}

Update-MgBetaNetworkAccessForwardingProfile -ForwardingProfileId $forwardingProfileId -BodyParameter $params

```
This example shows how to use the Update-MgBetaNetworkAccessForwardingProfile Cmdlet.

