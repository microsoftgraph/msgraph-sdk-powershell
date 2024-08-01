### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.DeviceManagement.Administration

$params = @{
	"@odata.type" = "#microsoft.graph.deviceAndAppManagementRoleAssignment"
	displayName = "Display Name value"
	description = "Description value"
	resourceScopes = @(
	"Resource Scopes value"
)
members = @(
"Members value"
)
}

Update-MgDeviceManagementRoleAssignment -DeviceAndAppManagementRoleAssignmentId $deviceAndAppManagementRoleAssignmentId -BodyParameter $params

```
This example shows how to use the Update-MgDeviceManagementRoleAssignment Cmdlet.

