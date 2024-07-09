### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceRoleManagementAlert -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole'" -ExpandProperty "alertDefinition,alertConfiguration,alertIncidents" 

```
This example shows how to use the Get-MgBetaIdentityGovernanceRoleManagementAlert Cmdlet.

