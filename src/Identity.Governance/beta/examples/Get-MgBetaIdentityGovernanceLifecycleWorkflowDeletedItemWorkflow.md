### Example 1: Get a deleted workflow

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow -WorkflowId $workflowId
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get specific properties of a deleted workflow

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow -WorkflowId $workflowId -Property "id,category,displayName,description,version,executionConditions"
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowDeletedItemWorkflow Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

