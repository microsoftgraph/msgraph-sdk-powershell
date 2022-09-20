### Example 1: Using the Join-MgSiteContentTypeWithHubSite Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	HubSiteUrls = @(
		"https://graph.microsoft.com/beta/sites/id"
	)
	PropagateToExistingLists = $false
}
Join-MgSiteContentTypeWithHubSite -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
This example shows how to use the Join-MgSiteContentTypeWithHubSite Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
