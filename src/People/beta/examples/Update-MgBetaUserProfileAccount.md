### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	countryCode = "NO"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfileAccount -UserId $userId -UserAccountInformationId $userAccountInformationId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileAccount Cmdlet.

