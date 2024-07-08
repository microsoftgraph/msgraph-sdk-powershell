### Example 1: Get the definition of a built-in role for the entitlement management provider

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaRoleManagementEntitlementManagementRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId

```
This example will get the definition of a built-in role for the entitlement management provider

