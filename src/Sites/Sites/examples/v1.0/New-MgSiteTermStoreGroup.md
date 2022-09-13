###Example 1
```
Import-Module Microsoft.Graph.Sites
$params = @{
	DisplayName = "myGroup"
}
New-MgSiteTermStoreGroup -SiteId $siteId -BodyParameter $params
```
