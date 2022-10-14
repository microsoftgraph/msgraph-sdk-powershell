### Example 1: Using the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -Filter "roleDefinitionId eq '62e90394-69f5-4237-9190-012177145e10'" -ExpandProperty "principal" 
```
This example shows how to use the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 2: Using the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -Filter  " principalId eq '5bde3e51-d13b-4db1-9948-fe4b109d11a7'" 
```
This example shows how to use the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 3: Using the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId -ExpandProperty "roleDefinition" 
```
This example shows how to use the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 4: Using the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId
```
This example shows how to use the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
### Example 5: Using the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet
```powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId -ExpandProperty "roleDefinition" 
```
This example shows how to use the Get-MgRoleManagementDirectoryRoleAssignment Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).
