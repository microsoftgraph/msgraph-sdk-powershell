### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Identity.Governance

$params = @{
	description = "Update basic properties of application registrations"
	displayName = "Application Registration Support Administrator"
	rolePermissions = @(
		@{
			allowedResourceActions = @(
			"microsoft.directory/applications/basic/read"
		)
	}
)
}

Update-MgRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId -BodyParameter $params

```
This example shows how to use the Update-MgRoleManagementDirectoryRoleDefinition Cmdlet.

