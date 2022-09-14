### Example 1: Using the Get-MgUserMemberGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	SecurityEnabledOnly = $true
}
# A UPN can also be used as -UserId.
Get-MgUserMemberGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the Get-MgUserMemberGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
