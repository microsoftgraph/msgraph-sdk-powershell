### Example 1: Using the Update-MgUserProfileAward Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	IssuingAuthority = "International Association of Branding Management"
	ThumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
}
Update-MgUserProfileAward -UserId $userId -PersonAwardId $personAwardId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileAward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
