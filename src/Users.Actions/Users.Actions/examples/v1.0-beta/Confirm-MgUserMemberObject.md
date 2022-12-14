### Example 1: Using the Confirm-MgBetaUserMemberObject Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Users.Actions
$params = @{
	Ids = @(
		"80a963dd-84af-4eb8-b2a6-781e444d4fb0"
		"62e90394-69f5-4237-9190-012177145e10"
		"86a64f51-3a64-4cc6-a8c8-6b8f000c0f52"
		"ac38546e-ddf3-437a-ac5c-27a94cd7a0f1"
	)
}
# A UPN can also be used as -UserId.
Confirm-MgBetaUserMemberObject -UserId $userId -BodyParameter $params
```
This example shows how to use the Confirm-MgBetaUserMemberObject Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
