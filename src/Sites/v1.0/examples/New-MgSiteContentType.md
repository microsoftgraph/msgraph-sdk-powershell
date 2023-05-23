### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	name = "docSet"
	description = "custom docset"
	base = @{
		name = "Document Set"
		id = "0x0120D520"
	}
	group = "Document Set Content Types"
}

New-MgSiteContentType -SiteId $siteId -BodyParameter $params
```
This example shows how to use the New-MgSiteContentType Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

