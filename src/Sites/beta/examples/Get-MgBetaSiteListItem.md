### Example 1: Using the Get-MgBetaSiteListItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
Get-MgBetaSiteListItem -SiteId $siteId -ListId $listId -ListItemId $listItemId -ExpandProperty "fields" 
```
This example shows how to use the Get-MgBetaSiteListItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
