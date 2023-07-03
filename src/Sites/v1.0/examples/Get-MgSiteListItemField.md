### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	Color = "Fuchsia"
	Quantity = 
}

Update-MgSiteListItemField -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the Get-MgSiteListItemField Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

