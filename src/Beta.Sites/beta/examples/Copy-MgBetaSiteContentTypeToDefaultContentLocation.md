### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	sourceFile = @{
		sharepointIds = @{
			listId = "e2ecf63b-b0fd-48f7-a54a-d8c15479e3b0"
			listItemId = "2"
		}
	}
	destinationFileName = "newname.txt"
}

Copy-MgBetaSiteContentTypeToDefaultContentLocation -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params

```
This example shows how to use the Copy-MgBetaSiteContentTypeToDefaultContentLocation Cmdlet.

