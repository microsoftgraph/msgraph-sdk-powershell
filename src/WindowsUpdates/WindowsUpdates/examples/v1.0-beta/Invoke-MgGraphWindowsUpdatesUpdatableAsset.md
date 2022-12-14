### Example 1: Using the Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	UpdateCategory = "feature"
	MemberEntityType = "#microsoft.graph.windowsUpdates.azureADDevice"
	Ids = @(
		"String"
		"String"
		"String"
	)
}
Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaGraphWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
