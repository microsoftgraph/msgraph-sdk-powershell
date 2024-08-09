### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	description = "Update basic properties and permission of application registrations"
### Example 2
	rolePermissions = @(
		@{
			allowedResourceActions = @(
			"Microsoft.CloudPC/CloudPCs/Read"
		"Microsoft.CloudPC/CloudPCs/Reprovision"
	)
}
)
}

Update-MgBetaRoleManagementCloudPcRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId -BodyParameter $params

```
This example shows how to use the Update-MgBetaRoleManagementCloudPcRoleDefinition Cmdlet.

