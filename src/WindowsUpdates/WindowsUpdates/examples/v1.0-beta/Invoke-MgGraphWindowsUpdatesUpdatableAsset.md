### Example 1: Using the Invoke-MgGraphWindowsUpdatesUpdatableAsset Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	UpdateCategory = "feature"
	MemberEntityType = "#microsoft.graph.windowsUpdates.azureADDevice"
	Ids = @(
		"String"
		"String"
		"String"
	)
}
Invoke-MgGraphWindowsUpdatesUpdatableAsset -BodyParameter $params
```
This example shows how to use the Invoke-MgGraphWindowsUpdatesUpdatableAsset Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
