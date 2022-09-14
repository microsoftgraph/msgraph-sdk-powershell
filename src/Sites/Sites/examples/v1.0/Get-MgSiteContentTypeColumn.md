### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId -ColumnDefinitionId $columnDefinitionId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId
```
