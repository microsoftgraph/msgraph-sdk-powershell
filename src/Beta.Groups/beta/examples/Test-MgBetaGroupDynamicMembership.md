### Example 1: Evaluate if a user or device is a member of an existing group

```powershell

Import-Module Microsoft.Graph.Beta.Groups

$params = @{
	memberId = "319b41e8-d9e4-42f8-bdc9-741113f48b33"
}

Test-MgBetaGroupDynamicMembership -GroupId $groupId -BodyParameter $params

```
This example will evaluate if a user or device is a member of an existing group

