### Example 1: Create a role assignment for a Cloud PC provider

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignmentMultiple"
	displayName = "My test role assignment 1"
	description = "My role assignment description"
	roleDefinitionId = "b5c08161-a7af-481c-ace2-a20a69a48fb1"
	principalIds = @(
	"f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
"c1518aa9-4da5-4c84-a902-a31404023890"
)
}

New-MgBetaRoleManagementCloudPcRoleAssignment -BodyParameter $params

```
This example will create a role assignment for a cloud pc provider

