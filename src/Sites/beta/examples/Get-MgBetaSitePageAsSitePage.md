### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSitePageAsSitePage -SiteId $siteId -BaseSitePageId $baseSitePageId

```
This example shows how to use the Get-MgBetaSitePageAsSitePage Cmdlet.

### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSitePageAsSitePage -SiteId $siteId -BaseSitePageId $baseSitePageId -Property "id,name" 

```
This example shows how to use the Get-MgBetaSitePageAsSitePage Cmdlet.

