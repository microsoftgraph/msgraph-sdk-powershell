### Example 1: Using the New-MgBetaSiteListItemLink Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	Type = "embed"
}
New-MgBetaSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteListItemLink Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the New-MgBetaSiteListItemLink Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	Type = "edit"
	Scope = "organization"
}
New-MgBetaSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteListItemLink Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the New-MgBetaSiteListItemLink Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	Type = "embed"
}
New-MgBetaSiteListItemLink -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteListItemLink Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
