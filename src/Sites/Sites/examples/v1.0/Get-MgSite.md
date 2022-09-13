###Example 1
```
Import-Module Microsoft.Graph.Sites
Get-MgSite -SiteId $siteId
```
###Example 2
```
Import-Module Microsoft.Graph.Sites
Get-MgSite -Search "{query}" 
```
###Example 3
```
Import-Module Microsoft.Graph.Sites
Get-MgSite -Search "{query}"  -OutFile $outFileId
```
