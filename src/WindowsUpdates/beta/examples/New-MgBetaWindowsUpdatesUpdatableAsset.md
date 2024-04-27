### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.WindowsUpdates

$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.updatableAssetGroup"
}

New-MgBetaWindowsUpdatesUpdatableAsset -BodyParameter $params

```
This example shows how to use the New-MgBetaWindowsUpdatesUpdatableAsset Cmdlet.

