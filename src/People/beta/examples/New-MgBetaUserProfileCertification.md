### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	certificationId = "KB-1235466333663322"
	description = "Blackbelt in Marketing - Brand Management"
	displayName = "Marketing Blackbelt - Brand Management"
	thumbnailUrl = "https://iame.io/dfhdfdfd334.jpg"
	webUrl = "https://www.iame.io/blackbelt"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileCertification -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileCertification Cmdlet.

