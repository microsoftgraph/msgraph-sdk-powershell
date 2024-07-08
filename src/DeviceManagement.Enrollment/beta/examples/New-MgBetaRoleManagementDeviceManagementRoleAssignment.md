### Example 1: Create a role assignment in Intune over two scope groups (which are Microsoft Entra objects)

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignmentMultiple"
	displayName = "My test role assignment 1"
	roleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034"
	principalIds = @(
	"f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
"c1518aa9-4da5-4c84-a902-a31404023890"
)
directoryScopeIds = @(
"28ca5a85-489a-49a0-b555-0a6d81e56f0d"
"8152656a-cf9a-4928-a457-1512d4cae295"
)
}

New-MgBetaRoleManagementDeviceManagementRoleAssignment -BodyParameter $params

```
This example will create a role assignment in intune over two scope groups (which are microsoft entra objects)

### Example 2: Create a role assignment in Intune at Intune-specific scope of "all Devices"

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

$params = @{
	"@odata.type" = "#microsoft.graph.unifiedRoleAssignmentMultiple"
	displayName = "My test role assignment 1"
	roleDefinitionId = "c2cf284d-6c41-4e6b-afac-4b80928c9034"
	principalIds = @(
	"f8ca5a85-489a-49a0-b555-0a6d81e56f0d"
"c1518aa9-4da5-4c84-a902-a31404023890"
)
appScopeIds = @(
"allDevices"
)
}

New-MgBetaRoleManagementDeviceManagementRoleAssignment -BodyParameter $params

```
This example will create a role assignment in intune at intune-specific scope of "all devices"

