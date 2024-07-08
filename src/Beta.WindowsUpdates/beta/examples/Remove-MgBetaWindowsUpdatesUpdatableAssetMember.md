### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	assets = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			id = "String (identifier)"
		}
	)
}

Remove-MgBetaWindowsUpdatesUpdatableAssetMember -UpdatableAssetId $updatableAssetId -BodyParameter $params

```
This example shows how to use the Remove-MgBetaWindowsUpdatesUpdatableAssetMember Cmdlet.

