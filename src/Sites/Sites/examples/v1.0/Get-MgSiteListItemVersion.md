### Example 1
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId
```
### Example 2
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -ListItemVersionId $listItemVersionId -ExpandProperty "fields" 
```
