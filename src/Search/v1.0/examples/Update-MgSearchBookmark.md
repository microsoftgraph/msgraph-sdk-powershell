### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Search

$params = @{
	description = "Book a fancy vacation in Tuscany or browse museums in Florence."
}

Update-MgSearchBookmark -BookmarkId $bookmarkId -BodyParameter $params

```
This example shows how to use the Update-MgSearchBookmark Cmdlet.

