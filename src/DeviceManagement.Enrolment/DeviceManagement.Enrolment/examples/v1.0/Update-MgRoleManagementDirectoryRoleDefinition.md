### Example 1: Using the Update-MgRoleManagementDirectoryRoleDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	Description = "Update basic properties of application registrations"
	DisplayName = "Application Registration Support Administrator"
	RolePermissions = @(
		@{
			AllowedResourceActions = @(
				"microsoft.directory/applications/basic/read"
			)
		}
	)
}
Update-MgRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId -BodyParameter $params
```
This example shows how to use the Update-MgRoleManagementDirectoryRoleDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
