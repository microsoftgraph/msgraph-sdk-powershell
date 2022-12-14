### Example 1: Using the New-MgBetaSiteListItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	Fields = @{
		Title = "Widget"
		Color = "Purple"
		Weight = 
	}
}
New-MgBetaSiteListItem -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteListItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
