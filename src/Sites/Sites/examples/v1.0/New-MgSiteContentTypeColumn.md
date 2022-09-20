### Example 1: Using the New-MgSiteContentTypeColumn Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	"SourceColumn@odata.bind" = "https://graph.microsoft.com/v1.0/sites/root/columns/99ddcf45-e2f7-4f17-82b0-6fba34445103"
}
New-MgSiteContentTypeColumn -SiteId $siteId -ContentTypeId $contentTypeId -BodyParameter $params
```
This example shows how to use the New-MgSiteContentTypeColumn Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
