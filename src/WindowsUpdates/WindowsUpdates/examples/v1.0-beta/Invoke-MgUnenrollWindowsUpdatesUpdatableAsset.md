### Example 1: Using the Invoke-MgBetaUnenrollWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	UpdateCategory = "String"
	Assets = @(
		@{
			"@odata.type" = "#microsoft.graph.windowsUpdates.azureADDevice"
			Id = "String (identifier)"
		}
	)
}
Invoke-MgBetaUnenrollWindowsUpdatesUpdatableAsset -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaUnenrollWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
