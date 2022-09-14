### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentType -SiteId $siteId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentType -SiteId $siteId -OutFile $outFileId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentType -SiteId $siteId -ContentTypeId $contentTypeId
```
