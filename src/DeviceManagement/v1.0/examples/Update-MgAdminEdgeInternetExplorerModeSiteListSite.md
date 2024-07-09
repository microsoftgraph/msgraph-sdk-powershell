### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	webUrl = "www.microsoft.com"
	targetEnvironment = "microsoftEdge"
	mergeType = "default"
	compatibilityMode = "default"
	allowRedirect = $false
	comment = "Updating to Edge."
}

Update-MgAdminEdgeInternetExplorerModeSiteListSite -BrowserSiteListId $browserSiteListId -BrowserSiteId $browserSiteId -BodyParameter $params

```
This example shows how to use the Update-MgAdminEdgeInternetExplorerModeSiteListSite Cmdlet.

