### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	issuingAuthority = "International Association of Branding Management"
	thumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
}

Update-MgBetaUserProfileAward -UserId $userId -PersonAwardId $personAwardId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileAward Cmdlet.

