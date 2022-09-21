### Example 1: Using the New-MgRoleManagementCloudPcRoleDefinition Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
$params = @{
	Description = "An example custom role"
	DisplayName = "ExampleCustomRole"
	RolePermissions = @(
		@{
			AllowedResourceActions = @(
				"Microsoft.CloudPC/CloudPCs/Read"
			)
		}
	)
	Condition = "null"
}
New-MgRoleManagementCloudPcRoleDefinition -BodyParameter $params
```
This example shows how to use the New-MgRoleManagementCloudPcRoleDefinition Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
