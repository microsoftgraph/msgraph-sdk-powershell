### Example 1: Using the Remove-MgBetaWindowsUpdatesUpdatableAssetMemberById Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.WindowsUpdates
$params = @{
	Ids = @(
		"String"
		"String"
		"String"
	)
	MemberEntityType = "#microsoft.graph.windowsUpdates.azureADDevice"
}
Remove-MgBetaWindowsUpdatesUpdatableAssetMemberById -UpdatableAssetId $updatableAssetId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaWindowsUpdatesUpdatableAssetMemberById Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
