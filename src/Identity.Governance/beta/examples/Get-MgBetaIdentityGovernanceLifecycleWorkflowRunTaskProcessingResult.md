### Example 1: Get the task processing results in a run report from a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult -WorkflowId $workflowId -RunId $runId

```
This example will get the task processing results in a run report from a workflow

### Example 2: Get the specific properties of task processing results in a run report for a workflow

```powershell

Import-Module Microsoft.Graph.Beta.Identity.Governance

Get-MgBetaIdentityGovernanceLifecycleWorkflowRunTaskProcessingResult -WorkflowId $workflowId -RunId $runId -Property "id,failureReason,processingStatus,subject" 

```
This example will get the specific properties of task processing results in a run report for a workflow

