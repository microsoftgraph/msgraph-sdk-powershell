### Example 1: Using the Update-MgUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	WebUrl = "https://github.com/innocenty.popov"
}
# A UPN can also be used as -UserId.
Update-MgUserProfileWebAccount -UserId $userId -WebAccountId $webAccountId -BodyParameter $params
```
This example shows how to use the Update-MgUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
