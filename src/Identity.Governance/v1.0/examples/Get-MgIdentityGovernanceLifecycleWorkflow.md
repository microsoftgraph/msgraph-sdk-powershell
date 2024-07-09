### Example 1: Retrieve all workflows created in the tenant

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflow

```
This example will retrieve all workflows created in the tenant

### Example 2: Retrieve only specific properties of "leaver" workflows

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflow -Filter "category eq 'leaver'" -Property "id,category,displayName,isEnabled,isSchedulingEnabled" 

```
This example will retrieve only specific properties of "leaver" workflows

