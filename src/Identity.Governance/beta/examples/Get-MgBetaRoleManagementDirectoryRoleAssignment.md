### Example 1: Request using a filter on roleDefinitionId and expand the principal object

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleAssignment -Filter "roleDefinitionId eq '62e90394-69f5-4237-9190-012177145e10'" -ExpandProperty "principal" 

```
This example will request using a filter on roledefinitionid and expand the principal object

### Example 2: Request using a filter on principal ID

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleAssignment -Filter  " principalId eq 'f1847572-48aa-47aa-96a3-2ec61904f41f'" 

```
This example will request using a filter on principal id

### Example 3: List privileged role assignments

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleAssignment -ExpandProperty "roleDefinition" -Filter "roleDefinition/isPrivileged eq true" 

```
This example will list privileged role assignments

