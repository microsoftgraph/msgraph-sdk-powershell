### Example 1: Retrieve all deleted workflows

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow

```
This example will retrieve all deleted workflows

### Example 2: Retrieve deleted workflows for "leaver" scenarios and return only specific properties

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow -Property "id,category,displayName,description,version" -Filter "category eq 'leaver'" 

```
This example will retrieve deleted workflows for "leaver" scenarios and return only specific properties

