### Example 1: Using the New-MgBetaSiteListItemDocumentSetVersion Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	Comment = "v1"
	ShouldCaptureMinorVersion = $false
}
New-MgBetaSiteListItemDocumentSetVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteListItemDocumentSetVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
