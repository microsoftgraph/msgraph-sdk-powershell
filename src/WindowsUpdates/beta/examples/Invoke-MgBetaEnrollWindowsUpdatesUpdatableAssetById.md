### Example 1: Using the Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById Cmdlet
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
Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById -BodyParameter $params
```
This example shows how to use the Invoke-MgBetaEnrollWindowsUpdatesUpdatableAssetById Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
