### Example 1: Using the New-MgBetaSiteColumn Cmdlet
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
New-MgBetaSiteColumn -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
