### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	required = $true
	hidden = $false
	propagateChanges = $false
}

Update-MgBetaSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId -ColumnDefinitionId $columnDefinitionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaSiteContentTypeColumn Cmdlet.

