###Example 1
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItem -SiteId $siteId -ListId $listId -ListItemId $listItemId -ExpandProperty "fields" 
```
