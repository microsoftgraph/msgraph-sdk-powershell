### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	comment = "v1"
	shouldCaptureMinorVersion = $false
}

New-MgSiteListItemDocumentSetVersion -SiteId $siteId -ListId $listId -ListItemId $listItemId -BodyParameter $params
```
This example shows how to use the New-MgSiteListItemDocumentSetVersion Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

