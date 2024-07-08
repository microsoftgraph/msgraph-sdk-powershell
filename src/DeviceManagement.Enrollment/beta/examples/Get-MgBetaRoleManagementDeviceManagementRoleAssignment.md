### Example 1: Get a directory-scoped roleAssignmentMultiple in an Intune provider

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

Get-MgBetaRoleManagementDeviceManagementRoleAssignment -UnifiedRoleAssignmentMultipleId $unifiedRoleAssignmentMultipleId

```
This example will get a directory-scoped roleassignmentmultiple in an intune provider

### Example 2: Get a roleAssignmentMultiple assigned to a group in an Intune provider

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

Get-MgBetaRoleManagementDeviceManagementRoleAssignment -Filter  " principalIds/any(x:x eq '564ae70c-73d9-476b-820b-fb61eb7384b9')" 

```
This example will get a roleassignmentmultiple assigned to a group in an intune provider

### Example 3: Get a directory-scoped roleAssignmentMultiple in an Intune provider with `$expand`

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

Get-MgBetaRoleManagementDeviceManagementRoleAssignment -UnifiedRoleAssignmentMultipleId $unifiedRoleAssignmentMultipleId -ExpandProperty "roleDefinition,principals,directoryScopes" 

```
This example will get a directory-scoped roleassignmentmultiple in an intune provider with `$expand`

