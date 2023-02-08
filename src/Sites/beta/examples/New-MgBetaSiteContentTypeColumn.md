### Example 1: Using the New-MgBetaSiteContentTypeColumn Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Sites
$params = @{
	"SourceColumn@odata.bind" = "https://graph.microsoft.com/beta/sites/root/columns/99ddcf45-e2f7-4f17-82b0-6fba34445103"
}
New-MgBetaSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
This example shows how to use the New-MgBetaSiteContentTypeColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
