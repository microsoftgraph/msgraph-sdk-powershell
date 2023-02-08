### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	SourceFile = @{
		SharepointIds = @{
			ListId = "e2ecf63b-b0fd-48f7-a54a-d8c15479e3b0"
			ListItemId = "2"
		}
	}
	DestinationFileName = "newname.txt"
}

Copy-MgBetaSiteContentTypeToDefaultContentLocation -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
This example shows how to use the Copy-MgBetaGroupSiteListContentTypeToDefaultContentLocation Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

