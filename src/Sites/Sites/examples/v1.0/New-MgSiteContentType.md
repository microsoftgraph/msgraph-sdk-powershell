### Example 1: Using the New-MgSiteContentType Cmdlet
```powershell
Import-Module Microsoft.Graph.Sites
$params = @{
	Name = "docSet"
	Description = "custom docset"
	Base = @{
		Name = "Document Set"
		Id = "0x0120D520"
	}
	Group = "Document Set Content Types"
}
New-MgSiteContentType -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgSiteContentType Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
