###Example 1
```
Import-Module Microsoft.Graph.Sites
$params = @{
	ContentType = "https://graph.microsoft.com/v1.0/sites/{site-id}/contentTypes/0x0101"
}
Add-MgSiteListContentTypeCopy -SiteId $siteId -ListId $listId -BodyParameter $params
```
