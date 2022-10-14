### Example 1: Using the Update-MgSearchBookmark Cmdlet
```powershell
Import-Module Microsoft.Graph.Search
$params = @{
	Description = "Book a fancy vacation in Tuscany or browse museums in Florence."
}
Update-MgSearchBookmark -BookmarkId $bookmarkId -BodyParameter $params
```
This example shows how to use the Update-MgSearchBookmark Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
