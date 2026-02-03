### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	allowedAudiences = "contacts"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfileAnniversary -UserId $userId -PersonAnnualEventId $personAnnualEventId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileAnniversary Cmdlet.

