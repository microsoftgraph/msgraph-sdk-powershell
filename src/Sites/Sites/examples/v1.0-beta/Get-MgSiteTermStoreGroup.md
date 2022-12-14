### Example 1: Using the Get-MgBetaSiteTermStoreGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSiteTermStoreGroup -SiteId $siteId -GroupId $groupId -Property "*,parentSiteId" 
```
This example shows how to use the Get-MgBetaSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgBetaSiteTermStoreGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSiteTermStoreGroup -SiteId $siteId -GroupId $groupId
```
This example shows how to use the Get-MgBetaSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
