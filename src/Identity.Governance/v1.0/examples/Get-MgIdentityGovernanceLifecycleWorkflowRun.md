### Example 1: Get a run report for a workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowRun -WorkflowId $workflowId -RunId $runId

```
This example will get a run report for a workflow

### Example 2: Get specific properties of a run report for a workflow

```powershell

Import-Module Microsoft.Graph.Identity.Governance

Get-MgIdentityGovernanceLifecycleWorkflowRun -WorkflowId $workflowId -RunId $runId -Property "id,failedTasksCount,failedUsersCount,processingStatus,totalTasksCount,totalUnprocessedTasksCount,totalUsersCount" 

```
This example will get specific properties of a run report for a workflow

