### Example 1
``` powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Comment = "v1"
	ShouldCaptureMinorVersion = $false
}
New-MgSiteListItemDocumentSetVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
