### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	type = "birthday"
	date = "1980-01-08"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileAnniversary -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileAnniversary Cmdlet.

