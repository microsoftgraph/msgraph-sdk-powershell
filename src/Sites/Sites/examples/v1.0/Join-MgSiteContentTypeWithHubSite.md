###Example 1
```
Import-Module Microsoft.Graph.Sites
$params = @{
	HubSiteUrls = @(
		"https://graph.microsoft.com/v1.0/sites/{site-id}"
	)
	PropagateToExistingLists = $false
}
Join-MgSiteContentTypeWithHubSite -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
