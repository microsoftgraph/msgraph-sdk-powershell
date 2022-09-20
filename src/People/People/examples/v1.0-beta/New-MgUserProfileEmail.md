### Example 1: Using the New-MgUserProfileEmail Cmdlet
```powershell
Import-Module Microsoft.Graph.People
$params = @{
	Address = "Innocenty.Popov@adventureworks.com"
}
# A UPN can also be used as -UserId.
New-MgUserProfileEmail -UserId $userId -BodyParameter $params
```
This example shows how to use the New-MgUserProfileEmail Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
