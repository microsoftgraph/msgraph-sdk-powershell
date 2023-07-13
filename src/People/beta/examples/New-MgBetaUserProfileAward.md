### Example 1: Using the New-MgBetaUserProfileAward Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Description = "Lifetime Achievement award from the International Association of Branding Managers"
	DisplayName = "Lifetime Achievement Award For Excellence in Branding"
	IssuedDate = "Date"
	IssuingAuthority = "International Association of Branding Management"
	ThumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
	WebUrl = "https://www.iabm.io"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileAward -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileAward Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
