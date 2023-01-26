### Example 1: Using the Update-MgBetaUserProfileAnniversary Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	AllowedAudiences = "contacts"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileAnniversary -UserId $userId -PersonAnnualEventId $personAnnualEventId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileAnniversary Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
