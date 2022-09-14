### Example 1
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItem -SiteId $siteId -ListId $listId -ListItemId $listItemId -ExpandProperty "fields" 
```
