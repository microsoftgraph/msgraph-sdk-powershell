### Example 1: Check group memberships for the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	securityEnabledOnly = $true
}

# A UPN can also be used as -UserId.
Get-MgBetaUserMemberGroup -UserId $userId -BodyParameter $params

```
This example will check group memberships for the signed-in user

