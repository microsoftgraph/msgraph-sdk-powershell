### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.People

$params = @{
	webUrl = "https://github.com/innocenty.popov"
}

# A UPN can also be used as -UserId.
Update-MgBetaUserProfileWebAccount -UserId $userId -WebAccountId $webAccountId -BodyParameter $params

```
This example shows how to use the Update-MgBetaUserProfileWebAccount Cmdlet.

