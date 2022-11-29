### Example 1: Using the New-MgUserProfileAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	AllowedAudiences = "organization"
	CountryCode = "NO"
}
# A UPN can also be used as -UserId.
New-MgUserProfileAccount -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
