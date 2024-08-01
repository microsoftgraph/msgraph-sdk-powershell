### Example 1: Get the definition of a custom role

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId

```
This example will get the definition of a custom role

### Example 2: Get the definition of a built-in role

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId

```
This example will get the definition of a built-in role

