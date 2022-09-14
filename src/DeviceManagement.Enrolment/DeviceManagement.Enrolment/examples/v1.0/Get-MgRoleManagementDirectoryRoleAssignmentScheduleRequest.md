### Example 1
``` powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -UnifiedRoleAssignmentScheduleRequestId $unifiedRoleAssignmentScheduleRequestId -Property "principalId,action,roleDefinitionId" -ExpandProperty "roleDefinition,activatedUsing,principal,targetSchedule" 
```
### Example 2
``` powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -UnifiedRoleAssignmentScheduleRequestId $unifiedRoleAssignmentScheduleRequestId
```
### Example 3
``` powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -Property "principalId,action,roleDefinitionId" -ExpandProperty "roleDefinition,activatedUsing,principal,targetSchedule" 
```
### Example 4
``` powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest
```
### Example 5
``` powershell
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -UnifiedRoleAssignmentScheduleRequestId $unifiedRoleAssignmentScheduleRequestId
```
