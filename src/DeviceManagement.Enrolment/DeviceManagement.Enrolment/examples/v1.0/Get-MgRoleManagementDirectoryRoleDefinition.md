###Example 1
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId
```
###Example 2
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId
```
###Example 3
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId -ExpandProperty "inheritsPermissionsFrom" 
```
###Example 4
```
Import-Module Microsoft.Graph.DeviceManagement.Enrolment
Get-MgRoleManagementDirectoryRoleDefinition
```
