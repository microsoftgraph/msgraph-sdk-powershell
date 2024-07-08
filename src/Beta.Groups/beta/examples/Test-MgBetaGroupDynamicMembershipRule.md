### Example 1: Evaluate if a user or device would be a member of a group based on a membership rule

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	memberId = "319b41e8-d9e4-42f8-bdc9-741113f48b33"
	membershipRule = "(user.displayName -startsWith "EndTestUser")"
}

Test-MgBetaGroupDynamicMembershipRule -BodyParameter $params

```
This example will evaluate if a user or device would be a member of a group based on a membership rule

