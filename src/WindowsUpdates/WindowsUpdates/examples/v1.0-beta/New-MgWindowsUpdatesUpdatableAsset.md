### Example 1: Using the New-MgWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.updatableAssetGroup"
}
New-MgWindowsUpdatesUpdatableAsset -BodyParameter $params
```
This example shows how to use the New-MgWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
