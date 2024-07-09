### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

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
isEnabled = "true"
}

New-MgBetaRoleManagementDirectoryRoleDefinition -BodyParameter $params

```
This example shows how to use the New-MgBetaRoleManagementDirectoryRoleDefinition Cmdlet.

