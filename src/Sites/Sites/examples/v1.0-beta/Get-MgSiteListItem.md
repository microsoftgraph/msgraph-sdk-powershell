### Example 1: Using the Get-MgSiteListItem Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItem -SiteId $siteId -ListId $listId -ListItemId $listItemId -ExpandProperty "fields" 
```
This example shows how to use the Get-MgSiteListItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
