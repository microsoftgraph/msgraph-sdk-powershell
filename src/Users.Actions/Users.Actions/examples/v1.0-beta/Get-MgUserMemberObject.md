### Example 1: Using the Get-MgBetaUserMemberObject Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	SecurityEnabledOnly = $true
}
# A UPN can also be used as -UserId.
Get-MgBetaUserMemberObject -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgBetaUserMemberObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
