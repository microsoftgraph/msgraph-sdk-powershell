### Example 1: Using the Copy-MgSiteContentTypeToDefaultContentLocation Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	SourceFile = @{
		SharepointIds = @{
			ListId = "e2ecf63b-b0fd-48f7-a54a-d8c15479e3b0"
			ListItemId = "2"
		}
	}
	DestinationFileName = "newname.txt"
}
Copy-MgSiteContentTypeToDefaultContentLocation -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
This example shows how to use the Copy-MgSiteContentTypeToDefaultContentLocation Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
