### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement

$params = @{
	displayName = "Production Site List A"
	description = "Production site list for team A"
}

Update-MgAdminEdgeInternetExplorerModeSiteList -BrowserSiteListId $browserSiteListId -BodyParameter $params

```
This example shows how to use the Update-MgAdminEdgeInternetExplorerModeSiteList Cmdlet.

