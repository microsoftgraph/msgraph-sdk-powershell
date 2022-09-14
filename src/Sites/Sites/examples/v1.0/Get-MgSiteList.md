### Example 1
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
### Example 3
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
### Example 4
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId -Property "id,name,lastModifiedDateTime" -ExpandProperty "columns(select=name,description),items)" 
```
### Example 5
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
### Example 6
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
