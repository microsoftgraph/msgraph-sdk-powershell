### Example 1: Using the New-MgBetaUserProfileWebAccount Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Description = "My Github contributions!"
	UserId = "innocenty.popov"
	Service = @{
		Name = "GitHub"
		WebUrl = "https://github.com"
	}
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileWebAccount -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileWebAccount Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
