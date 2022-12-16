### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

Get-MgSiteListItem -SiteId $siteId -ListId $listId -ExpandProperty "fields(select=Name,Color,Quantity)"
```
This example shows how to use the Get-MgShareListItem Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

