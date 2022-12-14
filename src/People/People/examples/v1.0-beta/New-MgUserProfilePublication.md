### Example 1: Using the New-MgBetaUserProfilePublication Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Description = "One persons journey to the top of the branding management field."
	DisplayName = "Got Brands? The story of Innocenty Popov and his journey to the top."
	PublishedDate = "Date"
	Publisher = "International Association of Branding Management Publishing"
	ThumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
	WebUrl = "https://www.iabm.io"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfilePublication -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfilePublication Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
