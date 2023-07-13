### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	required = $true
	hidden = $false
	propagateChanges = $false
}

Update-MgSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId -ColumnDefinitionId $columnDefinitionId -BodyParameter $params
```
This example shows how to use the Update-MgSiteContentTypeColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

