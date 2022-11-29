### Example 1: Using the Get-MgUserMemberObject Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	SecurityEnabledOnly = $true
}
# A UPN can also be used as -UserId.
Get-MgUserMemberObject -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgUserMemberObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
