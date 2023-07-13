### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

Get-MgSiteList -SiteId $siteId -ListId $listId
```
This example shows how to use the Get-MgSiteList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

Get-MgSiteList -SiteId $siteId -ListId $listId
```
This example shows how to use the Get-MgSiteList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 3: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

Get-MgSiteList -SiteId $siteId -ListId $listId -Property "id,name,lastModifiedDateTime" -ExpandProperty "columns(select=name,description),items)"
```
This example shows how to use the Get-MgSiteList Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

