### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	description = "One persons journey to the top of the branding management field."
	displayName = "Got Brands? The story of Innocenty Popov and his journey to the top."
	publishedDate = "Date"
	publisher = "International Association of Branding Management Publishing"
	thumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
	webUrl = "https://www.iabm.io"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfilePublication -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfilePublication Cmdlet.

