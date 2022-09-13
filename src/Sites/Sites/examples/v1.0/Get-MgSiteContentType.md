###Example 1
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentType -SiteId $siteId
```
###Example 2
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentType -SiteId $siteId -OutFile $outFileId
```
###Example 3
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteContentType -SiteId $siteId -ContentTypeId $contentTypeId
```
