### Example 1: Get the definition of a custom role for a directory provider

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId

```
This example will get the definition of a custom role for a directory provider

### Example 2: Get the definition of a built-in role for a directory provider

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementDirectoryRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId

```
This example will get the definition of a built-in role for a directory provider

