### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	description = "test"
	enforceUniqueValues = $false
	hidden = $false
	indexed = $false
	name = "Title"
	text = @{
		allowMultipleLines = $false
		appendChangesToExistingText = $false
		linesForEditing = 0
		maxLength = 255
	}
}

New-MgSiteListColumn -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the New-MgSiteListColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

