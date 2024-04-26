### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	description = "Lifetime Achievement award from the International Association of Branding Managers"
	displayName = "Lifetime Achievement Award For Excellence in Branding"
	issuedDate = "Date"
	issuingAuthority = "International Association of Branding Management"
	thumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
	webUrl = "https://www.iabm.io"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileAward -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileAward Cmdlet.

