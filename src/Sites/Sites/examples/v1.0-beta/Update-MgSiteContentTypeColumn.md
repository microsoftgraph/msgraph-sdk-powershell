### Example 1: Using the Update-MgSiteContentTypeColumn Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Required = $true
	Hidden = $false
	PropagateChanges = $false
}
Update-MgSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId -ColumnDefinitionId $columnDefinitionId -BodyParameter $params
```
This example shows how to use the Update-MgSiteContentTypeColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
