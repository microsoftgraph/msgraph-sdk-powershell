### Example 1: Using the New-MgRoleManagementDirectoryRoleDefinition Cmdlet
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
	IsEnabled = "true"
}
New-MgRoleManagementDirectoryRoleDefinition -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementDirectoryRoleDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
