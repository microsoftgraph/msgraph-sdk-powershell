### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Sites

$params = @{
	hubSiteUrls = @(
		"https://graph.microsoft.com/v1.0/sites/{site-id}"
	)
	propagateToExistingLists = $false
}

Join-MgSiteContentTypeWithHubSite -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params

```
This example shows how to use the Join-MgSiteContentTypeWithHubSite Cmdlet.

