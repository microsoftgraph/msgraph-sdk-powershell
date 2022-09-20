### Example 1: Using the Get-MgSiteTermStoreGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId -Property "*,parentSiteId" 
```
This example shows how to use the Get-MgSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgSiteTermStoreGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteTermStoreGroup -SiteId $siteId -GroupId $groupId
```
This example shows how to use the Get-MgSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
