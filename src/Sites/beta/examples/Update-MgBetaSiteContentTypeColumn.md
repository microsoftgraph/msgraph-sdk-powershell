### Example 1: Using the Update-MgBetaSiteContentTypeColumn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	Required = $true
	Hidden = $false
	PropagateChanges = $false
}
Update-MgBetaSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId -ColumnDefinitionId $columnDefinitionId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSiteContentTypeColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
