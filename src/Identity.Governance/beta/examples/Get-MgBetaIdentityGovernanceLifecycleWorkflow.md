### Example 1: Retrieve all workflows created in the tenant

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflow

```
This example will retrieve all workflows created in the tenant

### Example 2: Retrieve only specific properties of "leaver" workflows

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflow -Filter "category eq 'leaver'" -Property "id,category,displayName,isEnabled,isSchedulingEnabled" 

```
This example will retrieve only specific properties of "leaver" workflows

