### Example 1: Using the New-MgBetaUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.People
$params = @{
	Address = "Innocenty.Popov@adventureworks.com"
}
# A UPN can also be used as -UserId.
New-MgBetaUserProfileEmail -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgBetaUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
