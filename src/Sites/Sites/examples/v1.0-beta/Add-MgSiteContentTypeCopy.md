### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	ContentType = "https://graph.microsoft.com/v1.0/sites/{site-id}/contentTypes/0x0101"
}

Add-MgSiteListContentTypeCopy -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the Add-MgSiteContentTypeCopy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

