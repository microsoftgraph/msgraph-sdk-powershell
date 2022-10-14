### Example 1: Using the Test-MgGroupDynamicMembership Cmdlet
```powershell
Import-Module Microsoft.Graph.Groups
$params = @{
	MemberId = "319b41e8-d9e4-42f8-bdc9-741113f48b33"
}
Test-MgGroupDynamicMembership -GroupId $groupId -BodyParameter $params
```
This example shows how to use the Test-MgGroupDynamicMembership Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
