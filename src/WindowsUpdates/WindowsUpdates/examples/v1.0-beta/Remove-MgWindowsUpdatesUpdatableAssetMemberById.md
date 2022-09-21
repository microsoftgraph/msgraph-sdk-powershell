### Example 1: Using the Remove-MgWindowsUpdatesUpdatableAssetMemberById Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	Ids = @(
		"String"
		"String"
		"String"
	)
	MemberEntityType = "#microsoft.graph.windowsUpdates.azureADDevice"
}
Remove-MgWindowsUpdatesUpdatableAssetMemberById -UpdatableAssetId $updatableAssetId -BodyParameter $params
```
This example shows how to use the Remove-MgWindowsUpdatesUpdatableAssetMemberById Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
