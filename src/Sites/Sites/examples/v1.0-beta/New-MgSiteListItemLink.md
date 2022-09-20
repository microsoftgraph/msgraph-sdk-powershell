### Example 1: Using the New-MgSiteListItemLink Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Type = "embed"
}
New-MgSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgSiteListItemLink Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgSiteListItemLink Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Type = "edit"
	Scope = "organization"
}
New-MgSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgSiteListItemLink Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgSiteListItemLink Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Type = "embed"
}
New-MgSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgSiteListItemLink Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
