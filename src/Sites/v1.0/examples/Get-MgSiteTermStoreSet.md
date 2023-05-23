### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	description = "mySet"
}

Update-MgSiteTermStoreSet -SiteId $siteId -SetId $setId -BodyParameter $params
```
This example shows how to use the Get-MgSiteTermStoreSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

