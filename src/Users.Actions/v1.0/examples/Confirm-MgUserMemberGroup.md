### Example 1: Using the Confirm-MgUserMemberGroup Cmdlet
```powershell
Import-Module Microsoft.Graph.Users.Actions
$params = @{
	GroupIds = @(
		"fee2c45b-915a-4a64b130f4eb9e75525e"
		"4fe90ae065a-478b9400e0a0e1cbd540"
	)
}
# A UPN can also be used as -UserId.
Confirm-MgUserMemberGroup -UserId $userId -BodyParameter $params
```
This example shows how to use the Confirm-MgUserMemberGroup Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
