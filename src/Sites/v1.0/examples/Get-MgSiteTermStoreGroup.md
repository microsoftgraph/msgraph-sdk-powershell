### Example 1: Get a termStore group

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId

```
This example will get a termstore group

### Example 2: Get a site collection termStore group and its parent site ID

```powershell

Import-Module Microsoft.Graph.Sites

Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId -Property "*,parentSiteId" 

```
This example will get a site collection termstore group and its parent site id

