### Example 1: Using the Update-MgBetaUserProfileAward Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	IssuingAuthority = "International Association of Branding Management"
	ThumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
}
Update-MgBetaUserProfileAward -UserId $userId -PersonAwardId $personAwardId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileAward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
