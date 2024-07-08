### Example 1: Delete a site that was not previously published

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

Remove-MgBetaAdminEdgeInternetExplorerModeSiteListSite -BrowserSiteListId $browserSiteListId -BrowserSiteId $browserSiteId

```
This example will delete a site that was not previously published

### Example 2: Delete a site that was previously published

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

Remove-MgBetaAdminEdgeInternetExplorerModeSiteListSite -BrowserSiteListId $browserSiteListId -BrowserSiteId $browserSiteId

```
This example will delete a site that was previously published

