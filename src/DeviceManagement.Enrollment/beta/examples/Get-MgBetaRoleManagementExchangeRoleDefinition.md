### Example 1: Get the definition of a built-in role for the Exchange Online provider

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

Get-MgBetaRoleManagementExchangeRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId

```
This example will get the definition of a built-in role for the exchange online provider

