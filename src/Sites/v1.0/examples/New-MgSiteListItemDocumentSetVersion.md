### Example 1: Using the New-MgSiteListItemDocumentSetVersion Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Comment = "v1"
	ShouldCaptureMinorVersion = $false
}
New-MgSiteListItemDocumentSetVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgSiteListItemDocumentSetVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
