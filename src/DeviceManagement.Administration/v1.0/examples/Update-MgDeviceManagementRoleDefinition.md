### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.deviceAndAppManagementRoleDefinition"
	displayName = "Display Name value"
	description = "Description value"
	rolePermissions = @(
		@{
			"@odata.type" = "microsoft.graph.rolePermission"
			resourceActions = @(
				@{
					"@odata.type" = "microsoft.graph.resourceAction"
					allowedResourceActions = @(
					"Allowed Resource Actions value"
				)
				notAllowedResourceActions = @(
				"Not Allowed Resource Actions value"
			)
		}
	)
}
)
isBuiltIn = $true
}

Update-MgDeviceManagementRoleDefinition -RoleDefinitionId $roleDefinitionId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementRoleDefinition Cmdlet.

