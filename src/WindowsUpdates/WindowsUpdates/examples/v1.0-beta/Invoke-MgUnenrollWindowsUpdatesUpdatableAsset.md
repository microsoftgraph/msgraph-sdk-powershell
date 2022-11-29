### Example 1: Using the Invoke-MgUnenrollWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	UpdateCategory = "String"
	Assets = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
}
Invoke-MgUnenrollWindowsUpdatesUpdatableAsset -BodyParameter $params
```
This example shows how to use the Invoke-MgUnenrollWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
