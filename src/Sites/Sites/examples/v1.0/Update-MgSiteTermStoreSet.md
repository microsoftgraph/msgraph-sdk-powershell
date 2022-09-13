###Example 1
```
Import-Module Microsoft.Graph.Sites
$params = @{
	Description = "mySet"
}
Update-MgSiteTermStoreSet -SiteId $siteId -SetId $setId -BodyParameter $params
```
