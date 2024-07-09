### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	hostOrDomain = "www.microsoft.com"
	sourceEnvironment = "microsoftEdge"
	displayName = "Microsoft Cookie"
	path = "/"
	hostOnly = $true
	comment = "Updating source environment."
}

Update-MgAdminEdgeInternetExplorerModeSiteListSharedCookie -BrowserSiteListId $browserSiteListId -BrowserSharedCookieId $browserSharedCookieId -BodyParameter $params

```
This example shows how to use the Update-MgAdminEdgeInternetExplorerModeSiteListSharedCookie Cmdlet.

