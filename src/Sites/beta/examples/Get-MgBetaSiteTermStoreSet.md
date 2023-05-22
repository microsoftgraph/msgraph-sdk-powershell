### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

$params = @{
	description = "mySet"
}

Update-MgBetaSiteTermStoreSet -SiteId $siteId -SetId $setId -BodyParameter $params
```
This example shows how to use the Get-MgBetaBetaSiteTermStoreSet Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

