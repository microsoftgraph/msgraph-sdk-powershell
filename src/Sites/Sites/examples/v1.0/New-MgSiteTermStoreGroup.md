### Example 1: Using the New-MgSiteTermStoreGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	DisplayName = "myGroup"
}
New-MgSiteTermStoreGroup -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
