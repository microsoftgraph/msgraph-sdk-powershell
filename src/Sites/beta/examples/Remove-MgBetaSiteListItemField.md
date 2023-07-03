### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

$params = @{
	Color = "Fuchsia"
	Quantity = 
}

Update-MgBetaSiteListItemField -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaBetaSiteListItemField Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

