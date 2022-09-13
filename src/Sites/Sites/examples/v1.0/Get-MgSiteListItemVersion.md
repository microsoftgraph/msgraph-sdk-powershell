###Example 1
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId
```
###Example 2
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -ListItemVersionId $listItemVersionId -ExpandProperty "fields" 
```
