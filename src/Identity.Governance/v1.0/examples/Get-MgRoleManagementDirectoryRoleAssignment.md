### Example 1 : Get the details of a role assignment

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId

```
This example will### example 1 : get the details of a role assignment

### Example 2: Get the details of a role assignment and expand the relationships

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId -ExpandProperty "roleDefinition" 

```
This example will get the details of a role assignment and expand the relationships

