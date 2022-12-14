### Example 1: Using the Add-MgBetaWindowsUpdatesUpdatableAssetMember Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	Assets = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
}
Add-MgBetaWindowsUpdatesUpdatableAssetMember -UpdatableAssetId $updatableAssetId -BodyParameter $params
```
This example shows how to use the Add-MgBetaWindowsUpdatesUpdatableAssetMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
