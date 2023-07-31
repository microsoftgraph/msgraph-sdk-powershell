### Example 1: Get a run report for a workflow

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRun -WorkflowId $workflowId -RunId $runId
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowRun Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

### Example 2: Get specific properties of a run report for a workflow

```powershellImport-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRun -WorkflowId $workflowId -RunId $runId -Property "id,failedTasksCount,failedUsersCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,totalUsersCount"
```
This example shows how to use the Get-MgBetaIdentityGovernanceLifecycleWorkflowRun Cmdlet.
To learn about permissions for this resource, see the [permissions reference](/graph/permissions-reference).

