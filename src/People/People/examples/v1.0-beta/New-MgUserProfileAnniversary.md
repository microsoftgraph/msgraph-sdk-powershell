### Example 1: Using the New-MgUserProfileAnniversary Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Type = "birthday"
	Date = "1980-01-08"
}
# A UPN can also be used as -UserId.
New-MgUserProfileAnniversary -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileAnniversary Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
