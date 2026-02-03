### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

$params = @{
	webUrl = "www.microsoft.com"
	targetEnvironment = "microsoftEdge"
	mergeType = "default"
	compatibilityMode = "default"
	allowRedirect = $false
	comment = "Updating to Edge."
}

Update-MgBetaAdminEdgeInternetExplorerModeSiteListSite -BrowserSiteListId $browserSiteListId -BrowserSiteId $browserSiteId -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminEdgeInternetExplorerModeSiteListSite Cmdlet.

