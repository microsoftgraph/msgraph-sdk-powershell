### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	"@odata.type" = "#microsoft.graph.browserSite"
	webUrl = "www.microsoft.com"
	targetEnvironment = "InternetExplorer11"
	comment = "A site that opens in InternetExplorer11"
	mergeType = "default"
	compatibilityMode = "default"
	allowRedirect = $true
}

New-MgAdminEdgeInternetExplorerModeSiteListSite -BrowserSiteListId $browserSiteListId -BodyParameter $params

```
This example shows how to use the New-MgAdminEdgeInternetExplorerModeSiteListSite Cmdlet.

