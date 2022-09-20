### Example 1: Using the Update-MgRoleManagementCloudPcRoleDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	Description = "Update basic properties and permission of application registrations"
	DisplayName = "ExampleCustomRole"
	RolePermissions = @(
		@{
			AllowedResourceActions = @(
				"Microsoft.CloudPC/CloudPCs/Read"
				"Microsoft.CloudPC/CloudPCs/Reprovision"
			)
		}
	)
}
Update-MgRoleManagementCloudPcRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId -BodyParameter $params
```
This example shows how to use the Update-MgRoleManagementCloudPcRoleDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
