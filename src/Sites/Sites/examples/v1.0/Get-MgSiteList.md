###Example 1
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId
```
###Example 2
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
###Example 3
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
###Example 4
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId -Property "id,name,lastModifiedDateTime" -ExpandProperty "columns(select=name,description),items)" 
```
###Example 5
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
###Example 6
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteList -SiteId $siteId -ListId $listId
```
