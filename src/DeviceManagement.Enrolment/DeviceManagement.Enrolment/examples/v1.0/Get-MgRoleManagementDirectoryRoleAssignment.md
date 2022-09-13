###Example 1
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -Filter "roleDefinitionId eq '62e90394-69f5-4237-9190-012177145e10'" -ExpandProperty "principal" 
```
###Example 2
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -Filter  " principalId eq '5bde3e51-d13b-4db1-9948-fe4b109d11a7'" 
```
###Example 3
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId -ExpandProperty "roleDefinition" 
```
###Example 4
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId
```
###Example 5
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId -ExpandProperty "roleDefinition" 
```
