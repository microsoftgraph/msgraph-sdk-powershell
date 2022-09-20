### Example 1: Using the New-MgWindowsUpdatesResourceConnection Cmdlet
```powershell
Import-Module Microsoft.Graph.WindowsUpdates
$params = @{
	"@odata.type" = "#microsoft.graph.windowsUpdates.operationalInsightsConnection"
	AzureSubscriptionId = "322ec614-e9c2-4cd5-a55c-5711fdecf02e"
	AzureResourceGroupName = "target-resource-group"
	WorkspaceName = "my-workspace"
}
New-MgWindowsUpdatesResourceConnection -BodyParameter $params
```
This example shows how to use the New-MgWindowsUpdatesResourceConnection Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
