### Example 1: Using the New-MgBetaUserProfileCertification Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	CertificationId = "KB-1235466333663322"
	Description = "Blackbelt in Marketing - Brand Management"
	DisplayName = "Marketing Blackbelt - Brand Management"
	ThumbnailUrl = "https://iame.io/dfhdfdfd334.jpg"
	WebUrl = "https://www.iame.io/blackbelt"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileCertification -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileCertification Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
