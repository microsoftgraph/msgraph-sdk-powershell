### Example 1: Using the New-MgSiteListColumn Cmdlet
```powershell
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
This example shows how to use the New-MgSiteListColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
