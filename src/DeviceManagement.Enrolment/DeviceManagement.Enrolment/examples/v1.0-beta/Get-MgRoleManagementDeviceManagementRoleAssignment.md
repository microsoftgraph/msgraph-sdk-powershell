### Example 1: Using the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDeviceManagementRoleAssignment -UnifiedRoleAssignmentMultipleId $unifiedRoleAssignmentMultipleId -ExpandProperty "roleDefinition,principals,directoryScopes" 
```
This example shows how to use the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDeviceManagementRoleAssignment -Filter  " principalIds/any(x:x eq '564ae70c-73d9-476b-820b-fb61eb7384b9')"  -OutFile $outFileId
```
This example shows how to use the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDeviceManagementRoleAssignment -Filter  " principalIds/any(x:x eq '564ae70c-73d9-476b-820b-fb61eb7384b9')" 
```
This example shows how to use the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDeviceManagementRoleAssignment -UnifiedRoleAssignmentMultipleId $unifiedRoleAssignmentMultipleId
```
This example shows how to use the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDeviceManagementRoleAssignment -Filter "principalId eq '9e47fc6f-2d7a-464c-944e-d3dd0de522e4'" 
```
This example shows how to use the Get-MgRoleManagementDeviceManagementRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
