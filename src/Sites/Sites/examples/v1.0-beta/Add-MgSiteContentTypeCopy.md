### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	ContentType = "https://graph.microsoft.com/v1.0/sites/{site-id}/contentTypes/0x0101"
}

Add-MgBetaSiteListContentTypeCopy -SiteId $siteId -ListId $listId -BodyParameter $params
```
This example shows how to use the Add-MgBetaSiteContentTypeCopy Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

