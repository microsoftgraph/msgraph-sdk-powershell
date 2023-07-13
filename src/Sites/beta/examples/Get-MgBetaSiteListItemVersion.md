### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Sites

Get-MgBetaSiteListItemVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -ListItemVersionId $listItemVersionId -ExpandProperty "fields"
```
This example shows how to use the Get-MgBetaSiteListItemVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

