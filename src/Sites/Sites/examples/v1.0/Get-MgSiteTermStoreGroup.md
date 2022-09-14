### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -OutFile $outFileId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId -Property "*,parentSiteId" 
```
