### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.roleAssignment"
	displayName = "Display Name value"
	description = "Description value"
	resourceScopes = @(
	"Resource Scopes value"
)
}

Update-MgDeviceManagementRoleDefinitionRoleAssignment -RoleDefinitionId $roleDefinitionId -RoleAssignmentId $roleAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementRoleDefinitionRoleAssignment Cmdlet.

