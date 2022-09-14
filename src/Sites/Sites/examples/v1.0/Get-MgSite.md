### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -SiteId $siteId
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -Search "{query}" 
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.Sites
Get-MgSite -Search "{query}"  -OutFile $outFileId
```
