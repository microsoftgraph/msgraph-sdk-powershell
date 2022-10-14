### Example 1: Using the Invoke-MgEnrollWindowsUpdatesUpdatableAssetById Cmdlet
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
Invoke-MgEnrollWindowsUpdatesUpdatableAssetById -BodyParameter $params
```
This example shows how to use the Invoke-MgEnrollWindowsUpdatesUpdatableAssetById Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
