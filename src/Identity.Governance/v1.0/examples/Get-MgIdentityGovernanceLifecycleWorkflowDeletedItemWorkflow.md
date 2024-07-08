### Example 1: Get a deleted workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow -WorkflowId $workflowId

```
This example will get a deleted workflow

### Example 2: Get specific properties of a deleted workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow -WorkflowId $workflowId -Property "id,category,displayName,description,version,executionConditions" 

```
This example will get specific properties of a deleted workflow

