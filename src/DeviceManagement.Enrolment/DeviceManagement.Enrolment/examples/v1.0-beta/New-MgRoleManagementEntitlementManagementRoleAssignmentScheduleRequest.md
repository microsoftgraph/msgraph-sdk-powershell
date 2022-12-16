### Example 1: Retrieve role assignment requests

```powershellImport-Module Microsoft.Graph.DeviceManagement.Enrolment

Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest
```
This example shows how to use the New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Retrieve specified properties of role assignment requests and expand the relationships

```powershellImport-Module Microsoft.Graph.DeviceManagement.Enrolment

Get-MgRoleManagementDirectoryRoleAssignmentScheduleRequest -Property "principalId,action,roleDefinitionId" -ExpandProperty "roleDefinition,activatedUsing,principal,targetSchedule"
```
This example shows how to use the New-MgRoleManagementEntitlementManagementRoleAssignmentScheduleRequest Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

