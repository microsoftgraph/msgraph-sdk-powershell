### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Description = "test"
	EnforceUniqueValues = $false
	Hidden = $false
	Indexed = $false
	Name = "Title"
	Text = @{
		AllowMultipleLines = $false
		AppendChangesToExistingText = $false
		LinesForEditing = 0
		MaxLength = 255
	}
}
New-MgSiteListColumn -SiteId $siteId -ListId $listId -BodyParameter $params
```
