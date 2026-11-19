### Example 1 : Get direct and transitive role assignments of a principal

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignment -CountVariable CountVar -Filter "principalId eq '2c7936bc-3517-40f3-8eda-4806637b6516'"  -ConsistencyLevel eventual 


```
This example will get direct and transitive role assignments of a principal

### Example 2: Get direct and transitive assignments of a principal, but only specific role definitions

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignment -CountVariable CountVar -Filter "principalId eq '2c7936bc-3517-40f3-8eda-4806637b6516' and roleDefinitionId eq 'fe930be7-5e62-47db-91af-98c3a49a38b1'"  -ConsistencyLevel eventual 


```
This example will get direct and transitive assignments of a principal, but only specific role definitions

### Example 3: Get direct and transitive role assignments of a principal, but only administrative unit scoped

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryTransitiveRoleAssignment -CountVariable CountVar -Filter "principalId eq '2c7936bc-3517-40f3-8eda-4806637b6516' and directoryScopeId eq '/administrativeUnits/26e79164-0c5c-4281-8c5b-be7bc7809fb2'"  -ConsistencyLevel eventual 


```
This example will get direct and transitive role assignments of a principal, but only administrative unit scoped

