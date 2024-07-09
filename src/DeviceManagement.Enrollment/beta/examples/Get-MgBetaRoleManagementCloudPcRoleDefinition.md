### Example 1: Get the definition of a built-in role for a Cloud PC provider

```powershell

Import-Module Microsoft.Graph.Beta.DeviceManagement.Enrollment

Get-MgBetaRoleManagementCloudPcRoleDefinition -UnifiedRoleDefinitionId $unifiedRoleDefinitionId

```
This example will get the definition of a built-in role for a cloud pc provider

