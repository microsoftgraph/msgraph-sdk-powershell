### Example 1: Check group memberships for the signed-in user

```powershell

Import-Module Microsoft.Graph.Beta.Users.Actions

$params = @{
	groupIds = @(
	"fee2c45b-915a-4a64-b130-f4eb9e75525e"
"4fe90ae7-065a-478b-9400-e0a0e1cbd540"
)
}

# A UPN can also be used as -UserId.
Confirm-MgBetaUserMemberGroup -UserId $userId -BodyParameter $params

```
This example will check group memberships for the signed-in user

