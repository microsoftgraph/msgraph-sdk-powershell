### Example 1: Using the New-MgSiteColumn Cmdlet
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
New-MgSiteColumn -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgSiteColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
