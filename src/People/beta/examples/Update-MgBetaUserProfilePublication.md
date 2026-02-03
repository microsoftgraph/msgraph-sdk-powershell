### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	publisher = "International Association of Branding Management Publishing"
	thumbnailUrl = "https://iabm.io/sdhdfhsdhshsd.jpg"
}

Update-MgBetaUserProfilePublication -UserId $userId -ItemPublicationId $itemPublicationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfilePublication Cmdlet.

