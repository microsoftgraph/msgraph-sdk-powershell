### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Name = "docSet"
	Description = "custom docset"
	Base = @{
		Name = "Document Set"
		Id = "0x0120D520"
	}
	Group = "Document Set Content Types"
}
New-MgSiteContentType -SiteId $siteId -BodyParameter $params
```
