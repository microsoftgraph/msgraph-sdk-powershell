###Example 1
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -UnifiedRoleAssignmentScheduleRequestId $unifiedRoleAssignmentScheduleRequestId -Property "principalId,action,roleDefinitionId" -ExpandProperty "roleDefinition,activatedUsing,principal,targetSchedule" 
```
###Example 2
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -UnifiedRoleAssignmentScheduleRequestId $unifiedRoleAssignmentScheduleRequestId
```
###Example 3
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -Property "principalId,action,roleDefinitionId" -ExpandProperty "roleDefinition,activatedUsing,principal,targetSchedule" 
```
###Example 4
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest
```
###Example 5
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -UnifiedRoleAssignmentScheduleRequestId $unifiedRoleAssignmentScheduleRequestId
```
