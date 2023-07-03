### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	fields = @{
		Title = "Widget"
		Color = "Purple"
		Weight = 
	}
}

New-MgSiteListItem -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the New-MgSiteListItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

