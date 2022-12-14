### Example 1: Using the Add-MgBetaSiteListContentTypeCopy Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	ContentType = "https://graph.microsoft.com/beta/sites/id/contentTypes/0x0101"
}
Add-MgBetaSiteListContentTypeCopy -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the Add-MgBetaSiteListContentTypeCopy Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
