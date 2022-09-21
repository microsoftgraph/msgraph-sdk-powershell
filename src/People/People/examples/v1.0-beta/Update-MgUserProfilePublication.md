### Example 1: Using the Update-MgUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Publisher = "International Association of Branding Management Publishing"
	ThumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
}
Update-MgUserProfilePublication -UserId $userId -ItemPublicationId $itemPublicationId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
