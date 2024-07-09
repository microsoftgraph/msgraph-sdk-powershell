### Example 1: Retrieve role assignment requests

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest

```
This example will retrieve role assignment requests

### Example 2: Retrieve specified properties of role assignment requests and expand the relationships

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -Property "principalId,action,roleDefinitionId" -ExpandProperty "roleDefinition,activatedUsing,principal,targetSchedule" 

```
This example will retrieve specified properties of role assignment requests and expand the relationships

