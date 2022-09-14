### Example 1: Using the New-MgSiteListItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Fields = @{
		Title = "Widget"
		Color = "Purple"
		Weight = 
	}
}
New-MgSiteListItem -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the New-MgSiteListItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
