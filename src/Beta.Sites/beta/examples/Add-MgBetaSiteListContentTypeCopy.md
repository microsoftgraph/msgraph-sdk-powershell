### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	contentType = "https://graph.microsoft.com/beta/sites/id/contentTypes/0x0101"
}

Add-MgBetaSiteListContentTypeCopy -SiteId $siteId -ListId $listId -BodyParameter $params

```
This example shows how to use the Add-MgBetaSiteListContentTypeCopy Cmdlet.

