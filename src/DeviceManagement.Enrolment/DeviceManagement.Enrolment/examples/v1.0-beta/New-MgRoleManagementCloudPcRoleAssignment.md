### Example 1: Using the New-MgRoleManagementCloudPcRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignmentMultiple"
	DisplayName = "My test role assignment 1"
	Description = "My role assignment description"
	RoleDefinitionId = "b5c08161-a7af-481c-ace2-a20a69a48fb1"
	PrincipalIds = @(
		"f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
		"c1518aa9-4da5-4c84-a902-a31404023890"
	)
}
New-MgRoleManagementCloudPcRoleAssignment -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementCloudPcRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
