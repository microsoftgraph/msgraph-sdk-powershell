### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

$params = @{
	hostOrDomain = "www.microsoft.com"
	sourceEnvironment = "microsoftEdge"
	displayName = "Microsoft Cookie"
	path = "/"
	hostOnly = $true
	comment = "Updating source environment."
}

Update-MgBetaAdminEdgeInternetExplorerModeSiteListSharedCookie -BrowserSiteListId $browserSiteListId -BrowserSharedCookieId $browserSharedCookieId -BodyParameter $params

```
This example shows how to use the Update-MgBetaAdminEdgeInternetExplorerModeSiteListSharedCookie Cmdlet.

