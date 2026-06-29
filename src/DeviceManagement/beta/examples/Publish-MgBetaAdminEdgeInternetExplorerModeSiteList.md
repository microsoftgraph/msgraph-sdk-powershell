### Example 1: Publish all sites and shared cookies

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

$params = @{
	revision = "1.0"
}

Publish-MgBetaAdminEdgeInternetExplorerModeSiteList -BrowserSiteListId $browserSiteListId -BodyParameter $params

```
This example will publish all sites and shared cookies

### Example 2: Publish specific sites and shared cookies

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

$params = @{
	revision = "1.0"
	sites = @(
		@{
			id = "53e5f971-fc7b-4cd3-a1bf-34d7c0416882"
		}
		@{
			id = "2e27cc86-3662-447e-b751-274fb9f869ea"
		}
	)
	sharedCookies = @(
		@{
			id = "7f639835-23ab-4793-b1e6-1a06fad127a2"
		}
	)
}

Publish-MgBetaAdminEdgeInternetExplorerModeSiteList -BrowserSiteListId $browserSiteListId -BodyParameter $params

```
This example will publish specific sites and shared cookies

