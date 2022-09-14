### Example 1: Using the Get-MgSiteListItemVersion Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId
```
This example shows how to use the Get-MgSiteListItemVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgSiteListItemVersion Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
Get-MgSiteListItemVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -ListItemVersionId $listItemVersionId -ExpandProperty "fields" 
```
This example shows how to use the Get-MgSiteListItemVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
