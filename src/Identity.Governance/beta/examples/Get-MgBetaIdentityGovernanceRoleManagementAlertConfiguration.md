### Example 1: Code snippet

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceRoleManagementAlertConfiguration -Filter "scopeId eq '/' and scopeType eq 'DirectoryRole'" -ExpandProperty "alertDefinition" 

```
This example shows how to use the Get-MgBetaIdentityGovernanceRoleManagementAlertConfiguration Cmdlet.

