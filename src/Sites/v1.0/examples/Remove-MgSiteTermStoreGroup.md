### Example 1: Get a termStore group

```powershellImport-Module Microsoft.Graph.Sites

Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId
```
This example shows how to use the Remove-MgSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get a site collection termStore group and its parent site ID

```powershellImport-Module Microsoft.Graph.Sites

Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId -Property "*,parentSiteId"
```
This example shows how to use the Remove-MgSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

