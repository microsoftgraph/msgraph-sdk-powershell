###Example 1
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -OutFile $outFileId
```
###Example 2
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId
```
###Example 3
```
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId -Property "*,parentSiteId" 
```
