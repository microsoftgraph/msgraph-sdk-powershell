### Example 1: Get details of a role assignment

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId

```
This example will get details of a role assignment

### Example 2: Get details of a role assignment and expand the role definition

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleAssignment -UnifiedRoleAssignmentId $unifiedRoleAssignmentId -ExpandProperty "roleDefinition" 

```
This example will get details of a role assignment and expand the role definition

