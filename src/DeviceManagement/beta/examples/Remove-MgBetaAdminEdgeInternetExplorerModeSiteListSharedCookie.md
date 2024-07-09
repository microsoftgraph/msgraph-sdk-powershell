### Example 1: Delete a shared cookie that was not previously published

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

Remove-MgBetaAdminEdgeInternetExplorerModeSiteListSharedCookie -BrowserSiteListId $browserSiteListId -BrowserSharedCookieId $browserSharedCookieId

```
This example will delete a shared cookie that was not previously published

### Example 2: Delete a shared cookie that was previously published

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement

Remove-MgBetaAdminEdgeInternetExplorerModeSiteListSharedCookie -BrowserSiteListId $browserSiteListId -BrowserSharedCookieId $browserSharedCookieId

```
This example will delete a shared cookie that was previously published

