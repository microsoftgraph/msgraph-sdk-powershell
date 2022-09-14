### Example 1
``` powershell
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
	IsEnabled = $true
}
New-MgRoleManagementDirectoryRoleDefinition -BodyParameter $params
```
