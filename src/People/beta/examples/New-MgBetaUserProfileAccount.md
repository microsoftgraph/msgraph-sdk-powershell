### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	allowedAudiences = "organization"
	countryCode = "NO"
}

# A UPN can also be used as -UserId.
New-MgBetaUserProfileAccount -UserId $userId -BodyParameter $params

```
This example shows how to use the New-MgBetaUserProfileAccount Cmdlet.

