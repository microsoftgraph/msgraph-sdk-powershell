### Example 1: Using the Update-MgBetaUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	WebUrl = "https://github.com/innocenty.popov"
}
# A UPN can also be used as -UserId.
Update-MgBetaUserProfileWebAccount -UserId $userId -WebAccountId $webAccountId -BodyParameter $params
```
This example shows how to use the Update-MgBetaUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
