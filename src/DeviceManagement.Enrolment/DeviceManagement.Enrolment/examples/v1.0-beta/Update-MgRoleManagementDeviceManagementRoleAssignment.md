### Example 1: Using the Update-MgRoleManagementDeviceManagementRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	PrincipalIds = @(
		"0aeec2c1-fee7-4e02-b534-6f920d25b300"
		"2d5386a7-732f-44db-9cf8-f82dd2a1c0e0"
	)
}
Update-MgRoleManagementDeviceManagementRoleAssignment -UnifiedRoleAssignmentMultipleId $unifiedRoleAssignmentMultipleId -BodyParameter $params
```
This example shows how to use the Update-MgRoleManagementDeviceManagementRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
