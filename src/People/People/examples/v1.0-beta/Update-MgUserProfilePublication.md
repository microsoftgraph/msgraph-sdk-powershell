### Example 1: Using the Update-MgBetaUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Publisher = "International Association of Branding Management Publishing"
	ThumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
}
Update-MgBetaUserProfilePublication -UserId $userId -ItemPublicationId $itemPublicationId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
