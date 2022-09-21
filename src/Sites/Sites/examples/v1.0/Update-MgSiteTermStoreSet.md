### Example 1: Using the Update-MgSiteTermStoreSet Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Description = "mySet"
}
Update-MgSiteTermStoreSet -SiteId $siteId -SetId $setId -BodyParameter $params
```
This example shows how to use the Update-MgSiteTermStoreSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
