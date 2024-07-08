### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Groups

$params = @{
	groupId = "ffffffff-ffff-ffff-ffff-ffffffffffff"
}

Remove-MgGroupFromLifecyclePolicy -GroupLifecyclePolicyId $groupLifecyclePolicyId -BodyParameter $params

```
This example shows how to use the Remove-MgGroupFromLifecyclePolicy Cmdlet.

