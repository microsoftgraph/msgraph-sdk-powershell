### Example 2: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	description = "An example custom role"
	displayName = "ExampleCustomRole"
	rolePermissions = @(
		@{
			allowedResourceActions = @(
			"Microsoft.CloudPC/CloudPCs/Read"
		)
	}
)
condition = "null"
}

New-MgBetaRoleManagementCloudPcRoleDefinition -BodyParameter $params

```
This example shows how to use the New-MgBetaRoleManagementCloudPcRoleDefinition Cmdlet.

