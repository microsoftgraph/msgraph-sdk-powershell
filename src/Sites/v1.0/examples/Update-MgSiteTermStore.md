### Example 1: Code snippet

```powershellImport-Module Microsoft.Graph.Sites

$params = @{
	defaultLanguageTag = "en-US"
}

Update-MgSiteTermStore -SiteId $siteId -BodyParameter $params
```
This example shows how to use the Update-MgSiteTermStore Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

