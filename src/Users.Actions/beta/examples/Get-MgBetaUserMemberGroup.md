### Example 1: Using the Get-MgBetaUserMemberGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	SecurityEnabledOnly = $true
}
# A UPN can also be used as -UserId.
Get-MgBetaUserMemberGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgBetaUserMemberGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
