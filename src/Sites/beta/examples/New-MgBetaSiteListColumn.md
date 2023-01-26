### Example 1: Using the New-MgBetaSiteListColumn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
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
New-MgBetaSiteListColumn -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteListColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
