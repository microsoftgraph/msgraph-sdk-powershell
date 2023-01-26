### Example 1: Code snippet

```powershell
Import-Module Microsoft.Graph.Beta.Sites

$params = @{
	DefaultLanguageTag = "en-US"
}

Update-MgBetaSiteTermStore -SiteId $siteId -BodyParameter $params
```
This example shows how to use the Remove-MgBetaSiteTermStore Cmdlet.

To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

