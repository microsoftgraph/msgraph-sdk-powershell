### Example 1: Using the New-MgUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	CertificationId = "KB-1235466333663322"
	Description = "Blackbelt in Marketing - Brand Management"
	DisplayName = "Marketing Blackbelt - Brand Management"
	ThumbnailUrl = "https://iame.io/dfhdfdfd334.jpg"
	WebUrl = "https://www.iame.io/blackbelt"
}
# A UPN can also be used as -UserId.
New-MgUserProfileCertification -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
