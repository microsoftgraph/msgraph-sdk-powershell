### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteListItem -SiteId $siteId -ListId $listId -ListItemId $listItemId -ExpandProperty "fields"
```
This example shows how to use the Remove-MgBetaBetaSiteListItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

