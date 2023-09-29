### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

$params = @{
	displayName = "myGroup"
}

New-MgBetaSiteTermStoreGroup -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteTermStoreGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

