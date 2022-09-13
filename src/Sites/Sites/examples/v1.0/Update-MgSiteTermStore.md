###Example 1
```
Import-Module Microsoft.Graph.Sites
$params = @{
	DefaultLanguageTag = "en-US"
}
Update-MgSiteTermStore -SiteId $siteId -BodyParameter $params
```
