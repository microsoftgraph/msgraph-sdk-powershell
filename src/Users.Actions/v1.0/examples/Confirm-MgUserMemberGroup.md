### Example 1: Check group memberships for the signed-in user

```powershell

Import-Module Microsoft.Graph.Users.Actions

$params = @{
	groupIds = @(
	"fee2c45b-915a-4a64b130f4eb9e75525e"
"4fe90ae065a-478b9400e0a0e1cbd540"
)
}

# A UPN can also be used as -UserId.
Confirm-MgUserMemberGroup -UserId $userId -BodyParameter $params

```
This example will check group memberships for the signed-in user

