### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	hubSiteUrls = @(
		"https://graph.microsoft.com/beta/sites/id"
	)
	propagateToExistingLists = $false
}

Join-MgBetaSiteContentTypeWithHubSite -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params

```
This example shows how to use the Join-MgBetaSiteContentTypeWithHubSite Cmdlet.

