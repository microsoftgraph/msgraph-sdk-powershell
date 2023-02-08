### Example 1: Using the Update-MgBetaSearchBookmark Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Search
$params = @{
	Description = "Book a fancy vacation in Tuscany or browse museums in Florence."
}
Update-MgBetaSearchBookmark -BookmarkId $bookmarkId -BodyParameter $params
```
This example shows how to use the Update-MgBetaSearchBookmark Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
