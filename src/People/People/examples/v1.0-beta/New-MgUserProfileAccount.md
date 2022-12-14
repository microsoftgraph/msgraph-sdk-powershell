### Example 1: Using the New-MgBetaUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	AllowedAudiences = "organization"
	CountryCode = "NO"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileAccount -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
