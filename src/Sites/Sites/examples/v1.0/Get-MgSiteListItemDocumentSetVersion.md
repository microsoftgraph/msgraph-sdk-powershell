### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemDocumentSetVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -DocumentSetVersionId $documentSetVersionId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemDocumentSetVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId
```
