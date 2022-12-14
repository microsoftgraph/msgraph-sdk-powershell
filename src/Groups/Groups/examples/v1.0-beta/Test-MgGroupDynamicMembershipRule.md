### Example 1: Using the Test-MgBetaGroupDynamicMembershipRule Cmdlet
```powershell
Import-Module Microsoft.Graph.Beta.Groups
$params = @{
	MemberId = "319b41e8-d9e4-42f8-bdc9-741113f48b33"
	MembershipRule = "(user.displayName -startsWith "EndTestUser")"
}
Test-MgBetaGroupDynamicMembershipRule -BodyParameter $params
```
This example shows how to use the Test-MgBetaGroupDynamicMembershipRule Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
