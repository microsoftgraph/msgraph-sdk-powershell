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

New-MgDeviceManagementRoleDefinitionRoleAssignment -RoleDefinitionId $roleDefinitionId -BodyParameter $params

```
This example shows how to use the New-MgDeviceManagementRoleDefinitionRoleAssignment Cmdlet.

