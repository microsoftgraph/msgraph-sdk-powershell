### Example 1: Using the Join-MgBetaSiteContentTypeWithHubSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	HubSiteUrls = @(
		"https://graph.microsoft.com/beta/sites/id"
	)
	PropagateToExistingLists = $false
}
Join-MgBetaSiteContentTypeWithHubSite -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
This example shows how to use the Join-MgBetaSiteContentTypeWithHubSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
