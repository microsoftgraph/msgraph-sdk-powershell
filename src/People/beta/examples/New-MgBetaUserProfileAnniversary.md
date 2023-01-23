### Example 1: Using the New-MgBetaUserProfileAnniversary Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Type = "birthday"
	Date = "1980-01-08"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileAnniversary -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileAnniversary Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
