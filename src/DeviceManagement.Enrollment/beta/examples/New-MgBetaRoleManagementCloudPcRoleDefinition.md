### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	description = "An example custom role"
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

