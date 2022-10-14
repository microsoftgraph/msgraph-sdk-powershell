### Example 1: Using the Add-MgWindowsUpdatesUpdatableAssetMember Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	Assets = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
}
Add-MgWindowsUpdatesUpdatableAssetMember -UpdatableAssetId $updatableAssetId -BodyParameter $params
```
This example shows how to use the Add-MgWindowsUpdatesUpdatableAssetMember Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
