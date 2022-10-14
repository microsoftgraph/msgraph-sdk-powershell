### Example 1: Using the Add-MgSiteListContentTypeCopy Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	ContentType = "https://graph.microsoft.com/beta/sites/id/contentTypes/0x0101"
}
Add-MgSiteListContentTypeCopy -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the Add-MgSiteListContentTypeCopy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
